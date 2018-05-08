using System.Windows.Forms;

namespace Mytic
{
    public partial class MainForm : Form
    {
        Functions.FormModify Form = new Functions.FormModify();
        Functions.Network Network = new Functions.Network();

        Forms.SystemInfo SysInfo = new Forms.SystemInfo();

        public MainForm()
        {
            InitializeComponent();
            Form.EnableDrag(TopPanel);
        }

        private void LogoButton_Click(object sender, System.EventArgs e)
        {
            Network.OpenURL("https://github.com/TheGreyRaven/Mytic");
        }

        private void SysUtilButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = SysUtilButton.Top; HideSarter();
            if (!MarkerPanel.Visible){
                MainPanel.Controls.Clear();
                SysInfo.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(SysInfo);
                MarkerPanel.Show();
            }
        }

        private void TempButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = TempUtilButton.Top; HideSarter();
            if (!MarkerPanel.Visible){
                MainPanel.Controls.Clear();
                SysInfo.Dispose();
                MarkerPanel.Show();
            }
        }

        private void DiskUtilButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = DiskUtilButton.Top; HideSarter();
            if (!MarkerPanel.Visible){
                MainPanel.Controls.Clear();
                MarkerPanel.Show();
            }
        }

        private void CleanUtilButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = CleanUtilButton.Top; HideSarter();
            if (!MarkerPanel.Visible) {
                MainPanel.Controls.Clear();
                MarkerPanel.Show();
            }
        }

        private void ISOUitlButton_Click(object sender, System.EventArgs e)
        { MarkerPanel.Top = ISOUitlButton.Top; HideSarter();
            if (!MarkerPanel.Visible){
                MainPanel.Controls.Clear();
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
