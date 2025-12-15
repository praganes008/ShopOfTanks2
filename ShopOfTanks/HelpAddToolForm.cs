using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOfTanks
{
    public partial class HelpAddToolForm : Form
    {
        public HelpAddToolForm(string nameButton)
        {
            InitializeComponent();

            if(nameButton == "HelpBtn")
            {
                HelpAddToolTB.Text = System.IO.File.ReadAllText("HA_ToolFile.txt");
            }
            else if (nameButton == "HelpBtn2")
            {
                HelpAddToolTB.Text = System.IO.File.ReadAllText("HD_ToolFile.txt");
            }
            else if (nameButton == "HelpBtn3")
            {
                HelpAddToolTB.Text = System.IO.File.ReadAllText("HA_ProductFile.txt");
            }
            else if (nameButton == "HelpBtn4")
            {
                HelpAddToolTB.Text = System.IO.File.ReadAllText("HD_ProductFile.txt");
            }
        }

    }
}
