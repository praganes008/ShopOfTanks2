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
    public partial class InfoBDForm : Form
    {
        public InfoBDForm()
        {
            InitializeComponent();
        }

        private void InfoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoPanel.Controls.Clear();
            if (InfoCB.Text == "Танки")
            {
                List<string> list = SQL_class.mySelect("SELECT id, name FROM tanks");
                int y = 15;
                for (int i = 0; i < list.Count; i += 2)
                {
                    Label lbl_id = new Label();
                    lbl_id.Location = new Point(20, y);
                    lbl_id.Size = new Size(30, 20);
                    lbl_id.Text = list[i];
                    InfoPanel.Controls.Add(lbl_id);

                    Label lbl_name = new Label();
                    lbl_name.Location = new Point(55, y);
                    lbl_name.Size = new Size(200, 20);
                    lbl_name.Text = list[i + 1];
                    InfoPanel.Controls.Add(lbl_name);

                    y += 25;
                }

            }

            else if (InfoCB.Text == "Комплектующие")
            {
                List<string> list1 = SQL_class.mySelect("SELECT id, name, tank_id FROM parts");
                int y = 15;
                for (int i = 0; i < list1.Count; i += 3)
                {
                    Label lbl_id = new Label();
                    lbl_id.Location = new Point(20, y);
                    lbl_id.Size = new Size(30, 20);
                    lbl_id.Text = list1[i];
                    InfoPanel.Controls.Add(lbl_id);

                    Label lbl_name = new Label();
                    lbl_name.Location = new Point(55, y);
                    lbl_name.Size = new Size(250, 20);
                    lbl_name.Text = list1[i + 1];
                    InfoPanel.Controls.Add(lbl_name);

                    string tank = SQL_class.mySelect("SELECT name FROM tanks WHERE id = '" + list1[2] + "' ")[0];

                    Label lbl_tank = new Label();
                    lbl_tank.Location = new Point(300, y);
                    lbl_tank.Size = new Size(250, 20);
                    lbl_tank.Text = tank;
                    InfoPanel.Controls.Add(lbl_tank);

                    y += 30;
                }
            }

            else if (InfoCB.Text == "Пользователи")
            {
                List<string> list2 = SQL_class.mySelect("SELECT id, name FROM users");
                int y = 1;
                for (int i = 0; i < list2.Count; i += 2)
                {
                    Label lbl_id = new Label();
                    lbl_id.Location = new Point(20, y);
                    lbl_id.Size = new Size(30, 20);
                    lbl_id.Text = list2[i];
                    InfoPanel.Controls.Add(lbl_id);

                    Label lbl_name = new Label();
                    lbl_name.Location = new Point(55, y);
                    lbl_name.Size = new Size(200, 20);
                    lbl_name.Text = list2[i + 1];
                    InfoPanel.Controls.Add(lbl_name);

                    y += 30;
                }
            }
        }
    }
}
