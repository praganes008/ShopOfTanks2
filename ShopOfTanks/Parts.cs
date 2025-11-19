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
        public Parts(string tank_id)
        {
            InitializeComponent();

            List<string> parts = SQL_class.mySelect("SELECT id, name, price FROM parts WHERE tank_id = '"+ tank_id + "'");

            if (parts.Count>0)
            {
                int y = 85;
                for (int i = 0; i < parts.Count; i += 3)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(10, y);
                    lbl.Size = new Size(400, 20);
                    lbl.Text = parts[i+1] + " " + parts[i+2] + " руб.";
                    Controls.Add(lbl);

                    y += 25;
                }
            }
        }
    }
}
