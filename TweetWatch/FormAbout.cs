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
            labelVersion.Text = assembly.Version();
            labelCopyright.Text = assembly.Copyright();
        }
    }
}
