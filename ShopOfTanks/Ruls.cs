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
    public partial class Ruls : Form
    {
        public Ruls()
        {
            InitializeComponent();
            if(AusForm.isAdmin == true)
            { 
                    rulTB.Text = System.IO.File.ReadAllText("Admin_manual.txt");
            }
            else 
            {
                    rulTB.Text = System.IO.File.ReadAllText("User_manual.txt");
            }
           


        }
    }
}
