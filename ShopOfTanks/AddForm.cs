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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int a;
            if(!Int32.TryParse(MassaTB.Text, out a) || !Int32.TryParse(PriceTB.Text, out a))
            {
                MessageBox.Show("Массу и цену указывать ТОЛЬКО в ЦИФРАХ!");
                return;
            }

            if(NameTB.Text == "" || CountryComboBox.Text == "" || MassaTB.Text == "" || TypeComboBox.Text == "" || PriceTB.Text == "")
            {
                MessageBox.Show("Все поля обязательны к заполнению!");
                return;
            }
            //запись параметров объекта в SQL таблицу
            SQL_class.myUpdate("INSERT INTO tanks (name, country, massa, type, price, opis) VALUES ('" + NameTB.Text + "', '" + CountryComboBox.Text + "', '" + MassaTB.Text + "', '" + TypeComboBox.Text + "', '" + PriceTB.Text + "', '"+ OpisTB.Text + "')");
            
           
            if (FileName != "")
            {
                System.IO.File.Copy(FileName, "../../Pictures/" + NameTB.Text + ".jpeg");

            }

            //System.IO.File.AppendAllText("../../Pictures/" + NameTB.Text + ".txt", OpisTB.Text);

            if (NameTB.Text != "" && CountryComboBox.Text != "" && MassaTB.Text != "" && TypeComboBox.Text != "" && PriceTB.Text != "")
            {
                MessageBox.Show("Товар успешно добавлен!");
                Close();
            }
        }
       
        string FileName;
        private void LoadPicButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)                                                                  //когда мы нажали ОК в выборе в проводнике
            {
                FileName = openFileDialog1.FileName;       
                pictureBox1.Load(FileName);
            }
        }
    }
}
