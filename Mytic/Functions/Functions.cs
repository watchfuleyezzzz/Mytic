using System;
using System.Windows.Forms;

namespace Mytic.Functions
{
    class FormModify
    {
        public void EnableDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(DragForm_MouseDown); }
        public FormWindowState WindowState { get; private set; }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Form.ActiveForm.Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
