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
    public partial class ToolForm : Form
    {
        public ToolForm(string id)
        {
            InitializeComponent();
            List<string> list = SQL_class.mySelect("SELECT id, name, price, adres FROM parts WHERE tank_id = '" + id + "'");
            Text = list[1];
        }
    }
}
