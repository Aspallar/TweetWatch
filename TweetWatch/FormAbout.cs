using System;
using System.Reflection;
using System.Windows.Forms;

namespace TweetWatch
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            InitializeText();
        }

        private void InitializeText()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;
            labelVersion.Text = $"Version {version.Major}.{version.Minor}.{version.Build}";
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            labelCopyright.Text = ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }
    }
}
