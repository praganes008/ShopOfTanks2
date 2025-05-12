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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassvord.Text == textBoxResPasvord.Text)
            {
                if(textBoxName.Text != "" && textBoxFamil.Text != "" && textBoxLogin.Text != "" && textBoxPassvord.Text != "" && textBoxResPasvord.Text != "")
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
                else MessageBox.Show("Заполните все поля! Давай заполняй!");
            }
            else MessageBox.Show("Пароли не совпадают");
        }

    }
}
