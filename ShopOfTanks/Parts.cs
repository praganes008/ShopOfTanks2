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

            List<string> parts = SQL_class.mySelect("SELECT id, name, price, adres FROM parts WHERE tank_id = '"+ tank_id + "'");
            NameTankslbl.Text = SQL_class.mySelect("SELECT name FROM tanks WHERE id = '"+ tank_id + "'")[0];

            if (parts.Count>0)
            {
                int x = 370;
                int y = 85;
                for (int i = 0; i < parts.Count; i += 4)
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Location = new Point(x, y-10);
                    pic.Size = new Size(50, 50);
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    try
                        {
                        pic.Load("http://localhost/ShopOfTanks/image/" + parts[i+3]);
                        }
                    catch (Exception) { }
                    Controls.Add(pic);
                    

                    Label lbl = new Label();
                    lbl.Location = new Point(10, y);
                    lbl.Size = new Size(400, 20);
                    lbl.Text = parts[i+1] + " " + parts[i+2] + " руб.";
                    Controls.Add(lbl);

                    y += 60;
                }
            }
        }
    }
}
