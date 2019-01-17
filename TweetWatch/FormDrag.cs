using System;
using System.Windows.Forms;

namespace TweetWatch
{
    internal class FormDrag
    {
        IntPtr _target;

        public void AddSource(Control control)
        {
            if (_target == IntPtr.Zero)
                _target = control.FindForm().Handle;
            else if (_target != control.FindForm().Handle)
                throw new ArgumentException("All DragPump targets must be on same form");
            control.MouseDown += MouseDown;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(_target, Win.WM_NCLBUTTONDOWN, Win.HTCAPTION, 0);
            }
        }
    }
}
