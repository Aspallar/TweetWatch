using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TweetWatch
{
    public partial class FormMain : Form
    {
        private const string baseUrl = "https://twitter.com";

        private AlertSound _newTweetSound;
        private ToolTip _tooltip;
        private TwitterPoll _poll;
        private NotifyIcon _notifyIcon;

        public FormMain()
        {
            InitializeComponent();
            InitializeSound();
            IntializeTooltip();
            InitializeSiteDropdown();
            InitializeNotifyIcon();
            SetColor();
        }

        private void InitializeNotifyIcon()
        {
            if (Properties.Settings.Default.MinimizeToSystemTray)
            {
                _notifyIcon = new NotifyIcon();
                _notifyIcon.Icon = Icon;
                _notifyIcon.Visible = false;
                _notifyIcon.Click += notifyIcon_Click;
                _notifyIcon.BalloonTipClicked += notifyIcon_Click;
                _notifyIcon.Text = Text;
            }
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

        private readonly IntPtr HTCAPTION = new IntPtr(0x2);

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int WM_SYSCOMMAND = 0x112;
            const int SC_MAXIMIZE = 0xF030;
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = HTCAPTION;
                return;
            }
            else if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_MAXIMIZE)
            {
                return; // don't allow maximize (via caption double click)
            }
            base.WndProc(ref m);
        }

        private void InitializeSound()
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory 
                + Properties.Settings.Default.Sound;
             _newTweetSound = new AlertSound(fileName);
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
            buttonStart.Enabled = false;
            comboBoxSite.Enabled = false;
            string site = (string)comboBoxSite.SelectedItem;
            string url = baseUrl + "/" + site;
            Text += " - " + site;
            if (_notifyIcon != null)
                _notifyIcon.Text = Text;
            _poll = new TwitterPoll(
                url,
                new Progress<Tweet>(NewTweet),
                new Progress<TwitStatus>(StatusChanged),
                Properties.Settings.Default.Period
            );
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
            if (_notifyIcon != null && _notifyIcon.Visible)
                _notifyIcon.ShowBalloonTip(5000, Text, tweet.Text, ToolTipIcon.Info);
            _newTweetSound.Play();
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
            if (_notifyIcon == null)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                Visible = false;
                _notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            Visible = true;
            _notifyIcon.Visible = false;
            Activate();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
