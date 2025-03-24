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
    public partial class SelectedForm : Form
    {
        public static List<Product> selectProduct = new List<Product>(); 

        public SelectedForm()
        {
            InitializeComponent();

            Text = "Избранное" + AusForm.username;

            int x = 30;
            int y = 25;

            for (int i=0; i<selectProduct.Count; i++)
            {
                selectProduct[i].picture.Location = new Point(x, y);
                selectProduct[i].picture.Size = new Size(171, 166);
                selectProduct[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(selectProduct[i].picture);

                y += 220;
            }
        }
    }
}
