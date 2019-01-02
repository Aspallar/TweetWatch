using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace TweetWatch
{
    public partial class FormMain : Form
    {
        private const string baseUrl = "https://twitter.com";

        private SoundPlayer _newTweetSound;
        private ToolTip _tooltip;
        private TwitterPoll _poll;

        public FormMain()
        {
            InitializeComponent();
            InitializeSound();
            IntializeTooltip();
            InitializeSiteDropdown();
            SetColor();
        }

        private void IntializeTooltip()
        {
            _tooltip = new ToolTip();
            _tooltip.IsBalloon = true;
            _tooltip.SetToolTip(labelStatus, "Not Started");
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
                _newTweetSound = new SoundPlayer(fileName);
        }

        private void InitializeSiteDropdown()
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
            string url = baseUrl + "/" + site;
            Text += " - " + site;
            _poll = new TwitterPoll(url, new Progress<Tweet>(NewTweet), new Progress<TwitStatus>(StatusChanged));
            _poll.Start();
        }

        private void StatusChanged(TwitStatus status)
        {
            Color color;
            string message;
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
            _tooltip.SetToolTip(labelStatus, message);
        }

        private void NewTweet(Tweet tweet)
        {
            linkLabelTweetUrl.Text = tweet.Link;
            linkLabelTweetUrl.Visible = true;
            textBoxTweet.Text = tweet.Text;
            PlayNewTweetSound();
        }

        private void PlayNewTweetSound()
        {
            if (_newTweetSound != null)
                _newTweetSound.Play();
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
