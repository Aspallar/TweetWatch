using System;
using System.Drawing;
using System.Windows.Forms;
using TweetWatch.Properties;

namespace TweetWatch
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            InitializeFromApplicationSettings();
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

        private void buttonChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                textBoxColor.Text = ColorTranslator.ToHtml(color);
                panelColor.BackColor = color;
            }
        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                textBoxSound.Text = openFileDialog.FileName;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                UpdateApplicationSettings();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool Valid()
        {
            return true;
        }

        private void InitializeFromApplicationSettings()
        {
            Settings s = Settings.Default;
            numericUpDownPollPeriod.Value = s.Period;
            checkBoxMinimizeToTray.Checked = s.MinimizeToSystemTray;
            textBoxColor.Text = s.ColorString;
            panelColor.BackColor = s.Color;
            textBoxSound.Text = s.Sound;
        }

        private void UpdateApplicationSettings()
        {
            Settings s = Settings.Default;
            s.Period = (int)numericUpDownPollPeriod.Value;
            s.MinimizeToSystemTray = checkBoxMinimizeToTray.Checked;
            s.ColorString = textBoxColor.Text;
            s.Sound = textBoxSound.Text;
            s.Save();
        }
    }
}
