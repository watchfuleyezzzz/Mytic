﻿using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Mytic.Functions
{
    class Add
    {
        public void Drag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(DragForm_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

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
                SendMessage(Form.ActiveForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }

    class Network
    {
        public void OpenURL(String URL)
        {
            Process.Start(URL);
            return;
        }
    }
}
