using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace TweetWatch
{
    public partial class FormAbout : Form
    {
        private FormDrag _formDrag = new FormDrag();

        public FormAbout()
        {
            InitializeComponent();
            InitializeText();
            SetColor();
            _formDrag.AddSource(panelTop);
            _formDrag.AddSource(labelTitle);
        }

        private void SetColor()
        {
            Color color = Properties.Settings.Default.Color;
            panelTop.BackColor = color;
            panelLeft.BackColor = color;
            panelRight.BackColor = color;
            panelBottom.BackColor = color;
            button1.BackColor = color;
        }

        private void InitializeText()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            labelVersion.Text = assembly.Version();
            labelCopyright.Text = assembly.Copyright();
        }

    }
}
