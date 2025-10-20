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
    public partial class SettingsForm : Form
    {
        public static int Form1;
        public static int Form2;
        public static int Form3;
        public static string WeightST;
        public static string HightST;
        //public static int Weight = 1220;
        //public static int Hignt = 650;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Activate1Btn_Click(object sender, EventArgs e)
        {
            #region цвета для AusForm

            if (ComboBox1.Text == "Красный")
            {
                Form1 = 1;
            }
            if (ComboBox1.Text == "Оранженый")
            {
                Form1 = 2;
            }
            if (ComboBox1.Text == "Жёлтый")
            {
                Form1 = 3;
            }
            if (ComboBox1.Text == "Зелёный")
            {
                Form1 = 4;
            }
            if (ComboBox1.Text == "Голубой")
            {
                Form1 = 5;
            }
            if (ComboBox1.Text == "Синий")
            {
                Form1 = 6;
            }
            if (ComboBox1.Text == "Фиолетовый")
            {
                Form1 = 7;
            }
            if (ComboBox1.Text == "Белый")
            {
                Form1 = 8;
            }
            if (ComboBox1.Text == "Серый")
            {
                Form1 = 9;
            }
            if (ComboBox1.Text == "Чёрный")
            {
                Form1 = 10;
            }
            if (ComboBox1.Text == "По умолчанию")
            {
                Form1 = 11;
            }
            #endregion

            #region цвета для FiltrPanel

            if (ComboBox2.Text == "Красный")
            {
                Form2 = 1;
            }
            if (ComboBox2.Text == "Оранженый")
            {
                Form2 = 2;
            }
            if (ComboBox2.Text == "Жёлтый")
            {
                Form2 = 3;
            }
            if (ComboBox2.Text == "Зелёный")
            {
                Form2 = 4;
            }
            if (ComboBox2.Text == "Голубой")
            {
                Form2 = 5;
            }
            if (ComboBox2.Text == "Синий")
            {
                Form2 = 6;
            }
            if (ComboBox2.Text == "Фиолетовый")
            {
                Form2 = 7;
            }
            if (ComboBox2.Text == "Белый")
            {
                Form2 = 8;
            }
            if (ComboBox2.Text == "Серый")
            {
                Form2 = 9;
            }
            if (ComboBox2.Text == "Чёрный")
            {
                Form2 = 10;
            }
            if (ComboBox2.Text == "По умолчанию")
            {
                Form2 = 11;
            }
            #endregion

            #region цвета для MainForm

            if (ComboBox3.Text == "Красный")
            {
                Form3 = 1;
            }
            if (ComboBox3.Text == "Оранженый")
            {
                Form3 = 2;
            }
            if (ComboBox3.Text == "Жёлтый")
            {
                Form3 = 3;
            }
            if (ComboBox3.Text == "Зелёный")
            {
                Form3 = 4;
            }
            if (ComboBox3.Text == "Голубой")
            {
                Form3 = 5;
            }
            if (ComboBox3.Text == "Синий")
            {
                Form3 = 6;
            }
            if (ComboBox3.Text == "Фиолетовый")
            {
                Form3 = 7;
            }
            if (ComboBox3.Text == "Белый")
            {
                Form3 = 8;
            }
            if (ComboBox3.Text == "Серый")
            {
                Form3 = 9;
            }
            if (ComboBox3.Text == "Чёрный")
            {
                Form3 = 10;
            }
            if (ComboBox3.Text == "По умолчанию")
            {
                Form3 = 11;
            }
            #endregion



            /*if (TBon1.Text!=" " && TBon2.Text!=" ")
            {
                TBon1.Text = WeightST;
                TBon2.Text = HightST;

                Weight = int.Parse(WeightST);
                Hignt = int.Parse(HightST);

                //крч это перевод из стринга в инт и это для селект форм
            }*/
        }
    }
}
