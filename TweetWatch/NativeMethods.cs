using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TweetWatch
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr handle, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();
    }
}
