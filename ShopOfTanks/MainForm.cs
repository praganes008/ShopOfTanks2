using ShopOfTanks.Properties;
using System;
using System.Data.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public static List<Product> products = new List<Product>();

        public MainForm()
        {
         
            InitializeComponent();

            NameLabel.Visible = false;
            FiltrPanel.Height = HideButton.Height;
            HideButton.Text = "развернуть";
            MainSelectbutton.Visible = false;

            ReRead_SQL();
        }

        void ReRead_SQL()
        {
            List<string> tanks_list = mySelect("SELECT id, name, country, massa, type, price FROM tanks");

            products.Clear();

            for (int i=0; i<tanks_list.Count; i+=6)
            {                                                   
                Product product = new Product(tanks_list[i + 1],
                                              tanks_list[i + 2],
                                              Convert.ToInt32(tanks_list[i + 3]),
                                              tanks_list[i + 4],
                                              Convert.ToInt32(tanks_list[i + 5]));
                products.Add(product);
            }
            MainPanel.Controls.Clear();
        }

        private void PicProduct_Click(object sender, EventArgs e)//клик на картинку
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

        private void lblProduct_Click(object sender, EventArgs e)//клик на надпись
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

        private void HideButton_Click(object sender, EventArgs e)//развернуть/свернуть
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

        private void RegButton_Click(object sender, EventArgs e)//кнопка регистрации
        {
            RegForm frm = new RegForm();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)//загрузка MainForm
        {
            //раньше функция ReRead была тут
          /*      products.Clear();
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
            MainPanel.Controls.Clear();*/
            

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

        private void AusButton_Click(object sender, EventArgs e)//кнопка войти
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

        private void AddTankContextMenu_Click(object sender, EventArgs e)//добавить танк клик
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

        private void DeleteTankToolStripMenuItem_Click(object sender, EventArgs e)//удалить танк клик
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

        private void MainSelectbutton_Click(object sender, EventArgs e)//избранное
        {
            SelectedForm select = new SelectedForm();
            select.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)//правила
        {
            Ruls rul = new Ruls();
            rul.ShowDialog();
        }

        private void FeedBackButton_Click(object sender, EventArgs e)//обратная связь
        {
            FeedBackForm FBF = new FeedBackForm();
            FBF.ShowDialog();
        }

        private void SetBtn_Click(object sender, EventArgs e)//настройки
        {
            SettingsForm StsFrm = new SettingsForm();
            StsFrm.Show();
            RedrawBtn.Visible = true;
        }

        private void RedrawBtn_Click(object sender, EventArgs e)//настройки цвета форм, кнопка "обновить"
        { 
            RedrawBtn.Visible = false;
            #region цвета для AusPanel
            if (SettingsForm.Form1 == 1)
            {
                AusPanel.BackColor = Color.Red;
            }
            if (SettingsForm.Form1 == 2)
            {
                AusPanel.BackColor = Color.Orange;
            }
            if (SettingsForm.Form1 == 3)
            {
                AusPanel.BackColor = Color.Yellow;
            }
            if (SettingsForm.Form1 == 4)
            {
                AusPanel.BackColor = Color.Green;
            }
            if (SettingsForm.Form1 == 5)
            {
                AusPanel.BackColor = Color.LightBlue;
            }
            if (SettingsForm.Form1 == 6)
            {
                AusPanel.BackColor = Color.Blue;
            }
            if (SettingsForm.Form1 == 7)
            {
                AusPanel.BackColor = Color.Violet;
            }
            if (SettingsForm.Form1 == 8)
            {
                AusPanel.BackColor = Color.White;
            }
            if (SettingsForm.Form1 == 9)
            {
                AusPanel.BackColor = Color.Gray;
            }
            if (SettingsForm.Form1 == 10)
            {
                AusPanel.BackColor = Color.Black;
            }
            if (SettingsForm.Form1 == 11)
            {
                AusPanel.BackColor = Color.FromArgb(0, 192, 0);
            }
            #endregion

            #region цвета для FiltrPanel
            if (SettingsForm.Form2 == 1)
            {
                FiltrPanel.BackColor = Color.Red;
            }
            if (SettingsForm.Form2 == 2)
            {
                FiltrPanel.BackColor = Color.Orange;
            }
            if (SettingsForm.Form2 == 3)
            {
                FiltrPanel.BackColor = Color.Yellow;
            }
            if (SettingsForm.Form2 == 4)
            {
                FiltrPanel.BackColor = Color.Green;
            }
            if (SettingsForm.Form2 == 5)
            {
                FiltrPanel.BackColor = Color.LightBlue;
            }
            if (SettingsForm.Form2 == 6)
            {
                FiltrPanel.BackColor = Color.Blue;
            }
            if (SettingsForm.Form2 == 7)
            {
                FiltrPanel.BackColor = Color.Violet;
            }
            if (SettingsForm.Form2 == 8)
            {
                FiltrPanel.BackColor = Color.White;
            }
            if (SettingsForm.Form2 == 9)
            {
                FiltrPanel.BackColor = Color.Gray;
            }
            if (SettingsForm.Form2 == 10)
            {
                FiltrPanel.BackColor = Color.Black;
            }
            if (SettingsForm.Form2 == 11)
            {
                FiltrPanel.BackColor = Color.FromArgb(255, 128, 0);
            }
            #endregion

            #region цвета для MainPanel
            if (SettingsForm.Form3 == 1)
            {
                MainPanel.BackColor = Color.Red;
            }
            if (SettingsForm.Form3 == 2)
            {
                MainPanel.BackColor = Color.Orange;
            }
            if (SettingsForm.Form3 == 3)
            {
                MainPanel.BackColor = Color.Yellow;
            }
            if (SettingsForm.Form3 == 4)
            {
                MainPanel.BackColor = Color.Green;
            }
            if (SettingsForm.Form3 == 5)
            {
                MainPanel.BackColor = Color.LightBlue;
            }
            if (SettingsForm.Form3 == 6)
            {
                MainPanel.BackColor = Color.Blue;
            }
            if (SettingsForm.Form3 == 7)
            {
                MainPanel.BackColor = Color.Violet;
            }
            if (SettingsForm.Form3 == 8)
            {
                MainPanel.BackColor = Color.White;
            }
            if (SettingsForm.Form3 == 9)
            {
                MainPanel.BackColor = Color.Gray;
            }
            if (SettingsForm.Form3 == 10)
            {
                MainPanel.BackColor = Color.Black;
            }
            if (SettingsForm.Form3 == 11)
            {
                MainPanel.BackColor = Color.Blue;
            }
            #endregion

        }
    }
}
