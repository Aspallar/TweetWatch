using System;
using System.Runtime.InteropServices;

namespace TweetWatch
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr handle, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();
    }
}
