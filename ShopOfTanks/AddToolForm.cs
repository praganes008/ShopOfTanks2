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
    public partial class AddToolForm : Form
    {
        public AddToolForm()
        {
            InitializeComponent();

            List<string> tanks_list = SQL_class.mySelect("SELECT id, name From tanks");
            for (int i=0; i<tanks_list.Count; i+=2)
            {
                TankComboBox.Items.Add(tanks_list[i] + ". " + tanks_list[i+1]);
            }
        }

        string FileName = "";
        private void LoadPicBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)                                                                  //когда мы нажали ОК в выборе в проводнике
            {
                FileName = openFileDialog1.FileName;
                PicBox.Load(FileName);
                FileName = System.IO.Path.GetFileName(openFileDialog1.FileName);
            }
        }
        private void AddToolBtn_Click(object sender, EventArgs e)
        {
            int a;
            if (!Int32.TryParse(PriceTB.Text, out a))
            {
                MessageBox.Show("Цену указывать ТОЛЬКО в ЦИФРАХ!");
                return;
            }

            if (NameTB.Text == "" || TankComboBox.Text == "" || PriceTB.Text == "")
            {
                MessageBox.Show("Все поля обязательны к заполнению!");
                return;
            }

            string tank_id = TankComboBox.Text.Split(new string[] { ". " }, StringSplitOptions.None)[0];

            //запись параметров объекта в SQL таблицу
            SQL_class.myUpdate("INSERT INTO parts (name, price, tank_id, adres, opis) VALUES ('" + NameTB.Text + "', '" + PriceTB.Text + "', '" + tank_id + "', '" + FileName + "', '" + OpisanieTB.Text + "')");

            if (NameTB.Text != "" && TankComboBox.Text != "" && PriceTB.Text != "")
            {
                MessageBox.Show("Запчасть успешно добавлена!");
                Close();
            }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            HelpAddToolForm Add2Form = new HelpAddToolForm();
            Add2Form.ShowDialog();
        }
    }
}
