using System;
using System.Drawing;
using System.Linq;

namespace TweetWatch.Properties
{
    internal sealed partial class Settings
    {
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
