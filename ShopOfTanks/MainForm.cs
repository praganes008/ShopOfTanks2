using ShopOfTanks.Properties;
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

    public struct Product
    {
        public string name;
        public string country;
        public int massa;
        public string type;
        public int price;
        public PictureBox picture;
        public Label label;

        public Product(string _name, string _country, int _massa, string _type, int _price)
        {
            name = _name;
            country = _country;
            massa = _massa;
            type = _type;
            price = _price;
            picture = new PictureBox();
            try
            {
                picture.Load("../../Pictures/" + name + ".jpeg");
            }
            catch (Exception) { }

            picture.Tag = name;

            label = new Label();
            label.Text = name;
        }

    }


    public partial class MainForm : Form
    {
        //Product[] products = new Product[12];

        public static List<Product> products = new List<Product>();

        public MainForm()
        {
         
            InitializeComponent();

            NameLabel.Visible = false;
            FiltrPanel.Height = HideButton.Height;
            HideButton.Text = "развернуть";
            MainSelectbutton.Visible = false;


        }

        private void PicProduct_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            for(int i = 0; i< products.Count; i++)
            {
                if(pb.Tag.ToString() == products[i].name)
                {
                       ProductForm frm = new ProductForm(products[i]);
                       frm.Show();
                }
            }
            
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            for (int i = 0; i < products.Count; i++)
            {
                if (lbl.Text == products[i].name)
                {
                   ProductForm frm = new ProductForm(products[i]);
                    frm.Show(); 
                }
            }
            
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (FiltrPanel.Height == HideButton.Height)
            {
                FiltrPanel.Height = 128;
                HideButton.Text = "свернуть";
            }
            else
            {
                FiltrPanel.Height = HideButton.Height;
                HideButton.Text = "развернуть";
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm frm = new RegForm();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

                products.Clear();
                string[] strs = System.IO.File.ReadAllLines("../../Pictures/Products.txt");

                foreach (string str in strs)
                {
                    string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);                                                   //сринг, т.к у нас разделитель из 2х символов, тюе уже строка
                    Product product = new Product(parts[0],
                                                  parts[1],
                                                  Convert.ToInt32(parts[2]),
                                                  parts[3],
                                                  Convert.ToInt32(parts[4]));
                    products.Add(product);
                }
            MainPanel.Controls.Clear();
            

            int x = 30;
            int y = 25;
            for(int i=0; i < products.Count; i++)   
            {
                products[i].picture.Location = new Point(x, y);
                products[i].picture.Size = new Size(171, 166);
                products[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                products[i].picture.Click += new EventHandler(PicProduct_Click);
                MainPanel.Controls.Add(products[i].picture);

                products[i].label.Location = new Point(x+35, y+185);
                products[i].label.Size = new Size(113, 25);
                products[i].label.Click += new EventHandler(lblProduct_Click);
                MainPanel.Controls.Add(products[i].label);
                x += 200;
                if(x+171 > MainPanel.Width)
                {
                    x = 30;
                    y += 225;
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)//сёрч баттон
        {
            int x = 30;
            int y = 25;

            //фор для поиска всего.
            for (int i = 0; i < products.Count; i++)
            {

                products[i].picture.Visible = true;
                products[i].label.Visible = true;

                //название танка
                if (NameTextBox.Text != "" && !products[i].name.Contains(NameTextBox.Text))
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }

                //категория танка(тт, ст...)
                if (CategoryComboBox1.Text != "" && CategoryComboBox1.Text != products[i].type)
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }

                //страна производства танка
                if (CountryComboBox.Text != "" && CountryComboBox.Text != products[i].country)
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }

                //цена танка(до)
                if (MonyTextBox.Text != "" && Convert.ToInt32(MonyTextBox.Text) < products[i].price)
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }

                //масса
                if (mTextBox.Text != "" && Convert.ToInt32(mTextBox.Text) != products[i].massa)
                {
                    products[i].picture.Visible = false;
                    products[i].label.Visible = false;
                }

                //что бы они перестроились при поиске
                if (products[i].picture.Visible)
                {
                    products[i].picture.Location = new Point(x, y);
                    products[i].label.Location = new Point(x, y + 200);

                    x += 200;
                    if (x + 171 > MainPanel.Width)
                    {
                        x = 30;
                        y += 225;
                    }
                }
            }
        }

        private void MainPanel_Resize(object sender, EventArgs e)
        {
            SearchButton_Click(null, null);
        }

        private void AusButton_Click(object sender, EventArgs e)
        {
            if(AusButton.Text == "Войти")/*AusForm.username == ""*/
            {
                AusForm ausForm = new AusForm();
                ausForm.ShowDialog();

                if(AusForm.username != "")
                {
                AusButton.Text = "Выйти";
                NameLabel.Visible = true;
                
                    if(AusForm.isAdmin)
                    {
                        NameLabel.Text = "Вы успешно авторизовались как АДМИНИСТРАТОР";
                    }
                    else
                    {
                        NameLabel.Text = "Вы успешно авторизовались как " + AusForm.username;
                    }
                        
                RegButton.Visible = false;
                MainSelectbutton.Visible = true;
                }
                else
                {
                    AusForm.username = "";
                    AusButton.Text = "Войти";
                    NameLabel.Visible = false;
                    NameLabel.Text = "" + AusForm.username;
                    RegButton.Visible = true;
                    MainSelectbutton.Visible = false;
                    AusForm.isAdmin = false;
                }
            }
            else
            {
                AusForm.username = "";
                AusButton.Text = "Войти";
                NameLabel.Visible = false;
                NameLabel.Text = "" + AusForm.username;
                RegButton.Visible = true;
                MainSelectbutton.Visible = false;
                AusForm.isAdmin = false;
            }
           
        }

        private void AddTankContextMenu_Click(object sender, EventArgs e)
        {
            if(AusForm.isAdmin)
            {
                AddForm AddForm = new AddForm();
                AddForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("добавлять товары могут только админы!");
            }
            MainForm_Load(null, null);
        }

        private void DeleteTankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AusForm.isAdmin)
            {
                DelTank DelForm = new DelTank();
                DelForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("удалять товары могут только админы!");
            }
            MainForm_Load(null, null);
        }

        private void MainSelectbutton_Click(object sender, EventArgs e)
        {
            SelectedForm select = new SelectedForm();
            select.ShowDialog();
        }
    }
}
