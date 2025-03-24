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
    public partial class DelTank : Form
    {
        public DelTank()
        {
            InitializeComponent();
            for(int i = 0; i<MainForm.products.Count; i++)
            {
                DelComboBox1.Items.Add(MainForm.products[i].name);
            }
        }

        private void DelComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelTextBox.Text = DelComboBox1.Text;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить данный танк?", "удаление объекта", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                string name = "";
                System.IO.File.Delete("../../Pictures/Products.txt");

                for (int i = 0; i < MainForm.products.Count; i++)
                {
                    if (DelTextBox.Text == MainForm.products[i].name)
                    {

                    }
                    else
                    {
                        System.IO.File.AppendAllText("../../Pictures/Products.txt", MainForm.products[i].name + ", " +
                                                                           MainForm.products[i].country + ", " +
                                                                           MainForm.products[i].massa + ", " +
                                                                           MainForm.products[i].type + ", " +
                                                                           MainForm.products[i].price +
                                                                           Environment.NewLine);
                    }
                }
                MessageBox.Show("Танк успесшно удалён");
                Close();
            }

           
        }
    }
}
