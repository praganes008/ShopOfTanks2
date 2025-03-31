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
        public static Dictionary<Product, int> selectProduct = new Dictionary<Product, int>(); 

        public SelectedForm()
        {
            InitializeComponent();

            Text = "Избранное" + AusForm.username;

            int x = 30;
            int y = 25;

            foreach (KeyValuePair<Product, int> select_product in selectProduct)                                                   //foreach - для каждого (продукта в нашем массиве(selectProduct))
            {
                Product product = select_product.Key;

                #region 1 столбец - Картинка
                PictureBox pic = new PictureBox();
                pic.Location = new Point(x, y);
                pic.Size = new Size(171, 166);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = product.picture.Image;
                Controls.Add(pic);
                #endregion

                #region 2 столбец - Характеристики
                Label lbl_name = new Label();
                lbl_name.Location = new Point(x + 250, y);
                lbl_name.Size = new Size(200, 20);
                lbl_name.Text = "Товар: " + select_product.Key.name.ToString();
                Controls.Add(lbl_name);

                Label lbl_country = new Label();
                lbl_country.Location = new Point(x + 250, y+20);
                lbl_country.Size = new Size(300, 20);
                lbl_country.Text = "Страна производства: " + select_product.Key.country.ToString();
                Controls.Add(lbl_country);

                Label lbl_massa = new Label();
                lbl_massa.Location = new Point(x + 250, y + 40);
                lbl_massa.Size = new Size(300, 20);
                lbl_massa.Text = "Средняя масса машины(тонны): " + select_product.Key.massa.ToString();
                Controls.Add(lbl_massa);

                Label lbl_type = new Label();
                lbl_type.Location = new Point(x + 250, y + 60);
                lbl_type.Size = new Size(300, 20);
                lbl_type.Text = "Тип танка: " + select_product.Key.type.ToString();
                Controls.Add(lbl_type);

                Button btn_opis = new Button();
                btn_opis.Location = new Point(x + 250, y+90);
                btn_opis.Size = new Size(150, 35);
                btn_opis.Text = "К описанию";
                btn_opis.Tag = select_product.Key.name;
                btn_opis.Click += new EventHandler(open_product);
                Controls.Add(btn_opis);
                #endregion

                #region 3 столбец - Количество + Цена
                Label lbl_count = new Label();
                lbl_count.Location = new Point(x+650, y);
                lbl_count.Size = new Size(300, 20);
                lbl_count.Text = "Количество:";
                Controls.Add(lbl_count);

                NumericUpDown kol = new NumericUpDown();
                kol.Location = new Point(x + 650, y + 25);
                kol.Size = new Size(150, 20);
                kol.Value = select_product.Value;
                Controls.Add(kol);

                Label lbl_price = new Label();
                lbl_price.Location = new Point(x + 650, y+55);
                lbl_price.Size = new Size(300, 20);
                lbl_price.Text = "Цена: " + select_product.Key.price.ToString();
                Controls.Add(lbl_price);

                Label lbl_stoim = new Label();
                lbl_stoim.Location = new Point(x + 650, y + 75);
                lbl_stoim.Size = new Size(300, 20);
                lbl_stoim.Text = "Стоимость: ";
                Controls.Add(lbl_stoim);
                #endregion

                y += 220;
            }
        }
        private void open_product(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (KeyValuePair<Product, int> select_product in selectProduct)
            {
                if (btn.Tag.ToString() == select_product.Key.name)
                {
                    ProductForm frm = new ProductForm(select_product.Key);
                    frm.Show();
                }
            }

        }
    }
}
