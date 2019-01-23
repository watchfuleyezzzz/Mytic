﻿using System.Windows.Forms;

namespace Mytic
{
    public partial class MainForm : Form
    {
        Functions.FormModify Form = new Functions.FormModify();
        Functions.Network Network = new Functions.Network();

        public MainForm()
        {
            InitializeComponent();
            Form.EnableDrag(TopPanel);
        }

        private void LogoButton_Click(object sender, System.EventArgs e)
        { Network.OpenURL("https://github.com/TheGreyRaven/Mytic"); }

        private void SysUtilButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = SysUtilButton.Top; HideSarter();
            if (!MarkerPanel.Visible){
                MarkerPanel.Show();
            }
        }

        private void TempButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = TempUtilButton.Top; HideSarter();
            if (!MarkerPanel.Visible){
                MarkerPanel.Show();
            }
        }

        private void DiskUtilButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = DiskUtilButton.Top; HideSarter();
            if (!MarkerPanel.Visible){
                MarkerPanel.Show();
            }
        }

        private void CleanUtilButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = CleanUtilButton.Top; HideSarter();
            if (!MarkerPanel.Visible) {
                MarkerPanel.Show();
            }
        }

        private void ISOUitlButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = ISOUitlButton.Top; HideSarter();
            if (!MarkerPanel.Visible){
                MarkerPanel.Show();
            }
        }

        private void HideSarter()
        {
            if (LogoButton.Visible && LogoPanel.Visible && LogoLabel.Visible)
            { LogoButton.Hide(); LogoPanel.Hide(); LogoLabel.Hide(); }
        }
    }
}
