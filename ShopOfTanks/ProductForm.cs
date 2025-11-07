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

            try
                {
                OpistextBox.Text = SQL_class.mySelect("SELECT opis FROM tanks WHERE name '"+  +"'")[0]
                //OpistextBox.Text = System.IO.File.ReadAllText("../../Pictures/" + product.name + ".txt");
                }
            catch(Exception) { }
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

    }
}
