using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOfTanks
{
    public partial class ProductForm : Form
    {
        Product product;
        string tank_id;
        public ProductForm(Product _product)
        {
            InitializeComponent();

            if (AusForm.username != "")
            {
                AddSelectedButton.Visible = true;
            }
            else
            {
                AddSelectedButton.Visible = false;
            }
            product = _product;
            
            Text = product.name;
            ProductLabel.Text = product.name;
            ProductPictureBox.Image = product.picture.Image;
            CountryLabel.Text = "Страна производства: " + product.country;
            MassaLabel.Text = "Масса танка: " + product.massa;
            PriceLabel.Text = "Цена танка: " + product.price;
            CategoryLabel.Text = "Тип танка: " + product.type;


            List<string> tank = SQL_class.mySelect("SELECT id, opis FROM tanks WHERE name = '" + product.name +"'");
            OpistextBox.Text = tank[1];
            tank_id = tank[0];

        }

        private void AddSelectedButton_Click(object sender, EventArgs e)
        {
            //SelectedForm.Mailbtn.Visible = true;
            if (SelectedForm.selectProduct.ContainsKey(product))
            {
                SelectedForm.selectProduct[product]++;
            }
            else
            {
                SelectedForm.selectProduct.Add(product, 1);
            }
        }

        private void PartBtn_Click(object sender, EventArgs e)
        {
            Parts Prt = new Parts(tank_id);
            Prt.ShowDialog();
        }
    }
}
