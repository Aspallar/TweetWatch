﻿using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweetWatch
{
    public partial class FormMain : Form
    {
        private const string baseUrl = "https://twitter.com";

        private SynchronizationContext uiContext;
        private HtmlParser parser;
        private HttpClient client;
        private string url;
        private HashSet<string> currentTweets;
        private SoundPlayer newTweetSound;
        private TwitStatus status = TwitStatus.Stopped;
        private ToolTip tooltip;

        public FormMain()
        {
            InitializeComponent();
            InitializeSound();
            IntializeTooltip();
            SetColor();
            uiContext = SynchronizationContext.Current;
            parser = new HtmlParser();
            client = new HttpClient();
        }

        private void IntializeTooltip()
        {
            tooltip = new ToolTip();
            tooltip.IsBalloon = true;
            tooltip.SetToolTip(labelStatus, "Not Started");
        }

        private void SetColor()
        {
            Color color = Properties.Settings.Default.Color;
            panelTop.BackColor = color;
            panelBottom.BackColor = color;
            buttonClose.ForeColor = color;
            buttonMinimize.ForeColor = color;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCAPTION = 2;
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTCAPTION;
                return;
            }
            base.WndProc(ref m);
        }

        private void InitializeSound()
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory 
                + Properties.Settings.Default.Sound;
            if (File.Exists(fileName))
                newTweetSound = new SoundPlayer(fileName);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitTweetLink();
            InitSiteDropdown();
        }

        private void InitTweetLink()
        {
            linkLabelTweetUrl.Visible = false;
        }

        private void InitSiteDropdown()
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + "tweetsites.txt";
            if (File.Exists(fileName))
            {
                var sites = File.ReadAllLines(fileName).Select(x => x.Trim()).Where(x => x.Length > 0).ToArray();
                comboBoxSite.Items.AddRange(sites);
                if (sites.Length > 0)
                {
                    comboBoxSite.SelectedIndex = 0;
                    SetSiteLink();
                }
            }
        }

        private void SetSiteLink()
        {
            string site = (string)comboBoxSite.SelectedItem;
            if (site != null)
            {
                linkLabelSite.Visible = true;
                linkLabelSite.Text = "Go to " + site + " twitter";
                linkLabelSite.Tag = site;
            }
            else
            {
                linkLabelSite.Visible = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonMinimize.Enabled = true;
            buttonStart.Enabled = false;
            comboBoxSite.Enabled = false;
            string site = (string)comboBoxSite.SelectedItem;
            url = baseUrl + "/" + site;
            Text += " - " + site;
            Task.Run(async () =>
            {
                await InitializeCurrentTweets();
                while (true)
                {
                    await Task.Delay(Properties.Settings.Default.Period);
                    await Poll();
                }
            });
        }


        private async Task Poll()
        {
            IHtmlDocument doc = await GetTwitter();
            if (doc != null)
            {
                var tweets = doc.QuerySelectorAll("div.tweet");
                foreach (var tweet in tweets)
                {
                    string id = tweet.GetAttribute("data-tweet-id");
                    if (!currentTweets.Contains(id))
                    {
                        Tweet newTweet = new Tweet
                        {
                            Link = tweet.GetAttribute("data-permalink-path"),
                            Text = tweet.QuerySelector("p.tweet-text")?.TextContent ?? ""
                        };
                        currentTweets.Add(id);
                        ReportTweet(newTweet);
                        break; // foreach tweet
                    }
                }
            }
        }

        private async Task InitializeCurrentTweets()
        {
            IHtmlDocument doc = await GetTwitter();
            if (doc != null)
            {
                currentTweets = new HashSet<string>(doc.QuerySelectorAll("div.tweet")
                    .Select(x => x.GetAttribute("data-tweet-id")));
            }
        }

        private async Task<IHtmlDocument> GetTwitter()
        {
            try
            {
                var page = await client.GetStringAsync(url);
                UpdateStatus(TwitStatus.Working);
                var doc = parser.Parse(page);
                return doc;
            }
            catch (HttpRequestException)
            {
                UpdateStatus(TwitStatus.Failed);
                return null;
            }
        }

        private void UpdateStatus(TwitStatus newStatus)
        {
            if (status != newStatus)
            {
                status = newStatus;
                SetStatusInticator(newStatus);
            }
        }

        private void SetStatusInticator(TwitStatus newStatus)
        {
            uiContext.Post((o) =>
            {
                Color color;
                string message;
                TwitStatus status = (TwitStatus)o;
                if (status == TwitStatus.Failed)
                {
                    color = Color.Red;
                    message = "Unable to access twitter site";
                }
                else
                {
                    color = Color.Green;
                    message = "Monitoring twitter";
                }
                labelStatus.ForeColor = color;
                tooltip.SetToolTip(labelStatus, message);
            }, status);
        }

        public void ReportTweet(Tweet value)
        {
            uiContext.Post((o) =>
            {
                Tweet tweet = (Tweet)o;
                linkLabelTweetUrl.Text = tweet.Link;
                linkLabelTweetUrl.Visible = true;
                textBoxTweet.Text = tweet.Text;
                PlayNewTweetSound();
            }, value);
        }

        private void PlayNewTweetSound()
        {
            if (newTweetSound != null)
                newTweetSound.Play();
            else
                SystemSounds.Beep.Play();
        }

        private void linkLabelTweetUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(baseUrl + linkLabelTweetUrl.Text);
        }

        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSiteLink();
        }

        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(baseUrl + "\\" + (string)linkLabelSite.Tag);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            textBoxTweet.Focus();
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
