using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TweetWatch.Properties
{
    internal sealed partial class Settings
    {
        public string TwitListPath
        {
            get
            {
                if (Path.IsPathRooted(TwitListFile))
                    return TwitListFile;
                else
                    return Application.UserAppDataPath + "\\" + TwitListFile;
            }
        }

        public Color Color
        {
            get
            {
                Color color;
                if (ColorString[0] == '#')
                {
                    color = ColorTranslator.FromHtml(ColorString);
                }
                else if (ColorString.IndexOf(',') == -1)
                {
                    color = Color.FromName(ColorString);
                }
                else
                {
                    int[] c = ColorString.Split(',').Select(x => Convert.ToInt32(x.Trim())).ToArray();
                    return c.Length > 3 ? Color.FromArgb(c[0], c[1], c[2], c[3]) : Color.FromArgb(c[0], c[1], c[2]);
                }
                return color;
            }
        }
    }
}
