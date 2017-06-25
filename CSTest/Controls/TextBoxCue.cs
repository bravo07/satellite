using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSTest.Controls
{
    public class TextBoxCue : TextBox
    {
        public string Cue { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SendMessage(this.Handle, 0x1501, (IntPtr)1, Cue);
        }
    }
}
