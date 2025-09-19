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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            NoPasLbl.Visible = false;
        }
        int minLength = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassvord.Text == textBoxResPasvord.Text)
            {
                if (textBoxName.Text != "" && textBoxFamil.Text != "" && textBoxLogin.Text != "" && textBoxPassvord.Text != "" && textBoxResPasvord.Text != ""
                    && textBoxPassvord.TextLength > minLength)
                {
                    System.IO.File.AppendAllText("users.txt",
                                                textBoxName.Text + ", " +
                                                textBoxFamil.Text + ", " +
                                                textBoxLogin.Text + ", " +
                                                textBoxPassvord.Text + ", 0, " +
                                                MailTB.Text +
                                                Environment.NewLine);
                    MessageBox.Show("Регистрация прошла успешно!");
                    Close();
                }
                else { MessageBox.Show("Заполнины не все поля или заполнены не правельно!"); NoPasLbl.Visible = true; }
            }
            else MessageBox.Show("Пароли не совпадают!");
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxFamil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
