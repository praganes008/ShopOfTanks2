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
                HelpAddToolTB.Text = System.IO.File.ReadAllText("HelpAddToolFile.txt");
            }
            else if (nameButton == "HelpBtn")
            {
                HelpAddToolTB.Text = System.IO.File.ReadAllText("HelpDelToolFile.txt");
            }
        }

    }
}
