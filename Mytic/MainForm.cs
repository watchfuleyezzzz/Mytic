using System.Windows.Forms;

namespace Mytic
{
    public partial class MainForm : Form
    {
        Functions.Add Add = new Functions.Add();
        Functions.Network Network = new Functions.Network();

        public MainForm()
        {
            InitializeComponent();
            Add.Drag(TopPanel);
        }

        private void LogoButton_Click(object sender, System.EventArgs e)
        {
            Network.OpenURL("https://github.com/TheGreyRaven/Mytic");
        }
    }
}
