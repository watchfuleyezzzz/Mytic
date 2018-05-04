using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mytic
{
    public partial class MainForm : Form
    {
        Functions.Functions Functions = new Functions.Functions();
        public MainForm()
        {
            InitializeComponent();
            Functions.AddDrag(TopPanel);
        }
     
    }
}
