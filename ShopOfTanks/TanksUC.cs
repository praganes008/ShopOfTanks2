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
    public partial class TanksUC : UserControl
    {
        public TanksUC()
        {
            InitializeComponent();

            ReRead_SQL();
        }

        void ReRead_SQL()
        {
            List<string> tanks_list = SQL_class.mySelect("SELECT id, name, country, massa, type, price FROM tanks");

            MainForm.products.Clear();

            for (int i = 0; i < tanks_list.Count; i += 6)
            {
                Product product = new Product(tanks_list[i + 1],
                                              tanks_list[i + 2],
                                              Convert.ToInt32(tanks_list[i + 3]),
                                              tanks_list[i + 4],
                                              Convert.ToInt32(tanks_list[i + 5]));
                MainForm.products.Add(product);
            }
            ReDraw();
        }

        void ReDraw()
        {
            Controls.Clear();
            int x = 30;
            int y = 25;
            for (int i = 0; i < MainForm.products.Count; i++)
            {
                MainForm.products[i].picture.Location = new Point(x, y);
                MainForm.products[i].picture.Size = new Size(171, 166);
                MainForm.products[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                MainForm.products[i].picture.Click += new EventHandler(PicProduct_Click);
                Controls.Add(MainForm.products[i].picture);

                MainForm.products[i].label.Location = new Point(x + 35, y + 185);
                MainForm.products[i].label.Size = new Size(113, 25);
                MainForm.products[i].label.Click += new EventHandler(lblProduct_Click);
                Controls.Add(MainForm.products[i].label);
                x += 200;
                if (x + 171 > Width)
                {
                    x = 30;
                    y += 225;
                }
            }

        }

        private void PicProduct_Click(object sender, EventArgs e)//клик на картинку
        {
            PictureBox pb = (PictureBox)sender;
            for (int i = 0; i < MainForm.products.Count; i++)
            {
                if (pb.Tag.ToString() == MainForm.products[i].name)
                {
                    ProductForm frm = new ProductForm(MainForm.products[i]);
                    frm.Show();
                }
            }

        }

        private void lblProduct_Click(object sender, EventArgs e)//клик на надпись
        {
            Label lbl = (Label)sender;
            for (int i = 0; i < MainForm.products.Count; i++)
            {
                if (lbl.Text == MainForm.products[i].name)
                {
                    ProductForm frm = new ProductForm(MainForm.products[i]);
                    frm.Dock = DockStyle.Fill;
                    Controls.Clear();
                    Controls.Add(frm);
                }
            }

        }
    }

}
