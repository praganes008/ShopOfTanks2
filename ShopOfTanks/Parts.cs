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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
            List<string> parts = SQL_class.mySelect("SELECT id, name, price FROM parts WHERE '"+  +"'");
        }
    }
}
