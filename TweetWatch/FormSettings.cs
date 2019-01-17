using System;
using System.Drawing;
using System.Windows.Forms;
using TweetWatch.Properties;

namespace TweetWatch
{
    public partial class FormSettings : Form
    {
        private readonly Color errorColor = Color.Red;
        private FormDrag _formDrag = new FormDrag();

        public FormSettings()
        {
            InitializeComponent();
            InitializeFromApplicationSettings();
            SetColor();
            _formDrag.AddSource(panelTop);
            _formDrag.AddSource(labelTitle);
        }

        private void SetColor()
        {
            Color color = Properties.Settings.Default.Color;
            panelBottom.BackColor = color;
            panelTop.BackColor = color;
            buttonTitleClose.ForeColor = color;
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
                textBoxSound.Text = openFileDialog.FileName;
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
            bool valid = ValidateColor();
            return valid;
        }

        private bool ValidateColor()
        {
            string color = textBoxColor.Text.Trim();
            textBoxColor.Text = color;
            bool valid = Settings.IsValidColorString(color);
            if (!valid)
            {
                panelColorContainer.BackColor = errorColor;
                textBoxColor.Focus();
            }
            return valid;
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
