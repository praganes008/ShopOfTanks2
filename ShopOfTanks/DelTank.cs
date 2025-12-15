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
                for (int i = 0; i < MainForm.products.Count; i++)
                {
                    if (DelTextBox.Text == MainForm.products[i].name)
                    {
                        SQL_class.myUpdate("DELETE FROM tanks WHERE name = '"+ MainForm.products[i].name + "' ");
                        MessageBox.Show("Танк успесшно удалён");
                        Close();
                    }
                }
            }
        }

        private void HelpBtn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            HelpAddToolForm Add2Form = new HelpAddToolForm(button.Name.ToString());
            Add2Form.ShowDialog();
        }
    }
}
