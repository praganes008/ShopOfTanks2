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
    public partial class AusForm : Form
    {
        public static string username = "";
        public static bool isAdmin = false;
        public AusForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strs = System.IO.File.ReadAllLines("users.txt");
            foreach(string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                if(LoginTB.Text == parts[2] && PasswordTB.Text == parts[3])
                {
                    username = parts[0] + " " + parts[1];
                    isAdmin = (parts[4]=="1");
                    Close();
                    return;
                }
            }
            MessageBox.Show("Данные введены неверно!");
        }
    }
}
