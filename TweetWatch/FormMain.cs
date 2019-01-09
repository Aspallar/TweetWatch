using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private bool _autoStart;

        public FormMain(string startSite)
        {
            _autoStart = !string.IsNullOrEmpty(startSite);
            InitializeComponent();
            InitializeSound();
            IntializeTooltip();
            InitializeSiteDropdown(startSite);
            InitializeNotifyIcon();
            SetColor();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (_autoStart)
                StartPoll();
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
            string path = FilePath(Properties.Settings.Default.Sound);
             _newTweetSound = new AlertSound(path);
        }

        private void InitializeSiteDropdown(string startSite)
        {
            if (string.IsNullOrEmpty(startSite))
            {
                string path = FilePath(Properties.Settings.Default.TwitListFile);
                if (File.Exists(path))
                {
                    var sites = File.ReadAllLines(path).Select(x => x.Trim()).Where(x => x.Length > 0).ToArray();
                    comboBoxSite.Items.AddRange(sites);
                    if (sites.Length > 0)
                    {
                        comboBoxSite.SelectedIndex = 0;
                        SetSiteLink();
                    }
                }
            }
            else
            {
                comboBoxSite.Items.Add(startSite);
                comboBoxSite.SelectedIndex = 0;
                SetSiteLink();
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
            StartPoll();
        }

        private void StartPoll()
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
                Properties.Settings.Default.Period,
                $"TweetWatch/{Assembly.GetExecutingAssembly().Version()}"
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
            textBoxTweet.Text = tweet.Time.ToString() + "\r\n" + tweet.Text;
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
            Minimize();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Down))
            {
                Minimize();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Minimize()
        {
            if (_notifyIcon == null)
                WindowState = FormWindowState.Minimized;
            else
                SystemTrayMinimized(true);
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            SystemTrayMinimized(false);
            Activate();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SystemTrayMinimized(bool isMinimized)
        {
            Visible = !isMinimized;
            _notifyIcon.Visible = isMinimized;
        }

        private string FilePath(string fileName)
        {
            return Path.IsPathRooted(fileName)
                ? fileName
                : AppDomain.CurrentDomain.BaseDirectory + fileName;
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FormAbout formAbout = new FormAbout())
                formAbout.ShowDialog(this);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
