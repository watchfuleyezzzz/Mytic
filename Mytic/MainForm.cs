using System.Windows.Forms;

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
        {
            Network.OpenURL("https://github.com/TheGreyRaven/Mytic");
        }

        private void SysInfoButton_Click(object sender, System.EventArgs e)
        {
            if (LogoButton.Visible && LogoPanel.Visible && MarkerPanel.Visible && LogoLabel.Visible)
            LogoButton.Hide(); LogoPanel.Hide(); MarkerPanel.Show(); LogoLabel.Hide();
        }
    }
}
