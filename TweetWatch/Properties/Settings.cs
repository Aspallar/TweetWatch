using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
                    int[] c = SplitArgbColorString(ColorString);
                    return c.Length > 3 ? Color.FromArgb(c[0], c[1], c[2], c[3]) : Color.FromArgb(c[0], c[1], c[2]);
                }
                return color;
            }
        }

        public static bool IsValidColorString(string color)
        {
            bool valid;
            if (color.IndexOf(',') != -1)
            {
                try
                {
                    int[] c = SplitArgbColorString(color);
                    valid = (c.Length == 3 || c.Length == 4) && !c.Where(x => x < 0 || x > 255).Any();
                }
                catch (FormatException)
                {
                    valid = false;
                }
            }
            else if (color[0] == '#')
            {
                valid = (color.Length == 4 || color.Length == 7) && Regex.IsMatch(color, "#[0-9a-fA-F]+$");
            }
            else
            {
                valid = Color.FromName(color).IsKnownColor;
            }
            return valid;
        }

        private static int[] SplitArgbColorString(string color) 
            => color.Split(',').Select(x => Convert.ToInt32(x.Trim())).ToArray();
    }
}
