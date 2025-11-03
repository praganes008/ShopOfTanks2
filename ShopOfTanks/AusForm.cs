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
        public static string email = "";
        public static string username = "";
        public static bool isAdmin = false;
        public AusForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> users_list = SQL_class.mySelect("SELECT id, name, Famil, login, Passvord, IsAdmin, Mail FROM users");

            for(int i = 0; i < users_list.Count; i += 7)
            {
                if(LoginTB.Text == users_list[i + 3] && PasswordTB.Text == users_list[i + 4])
                {
                    username = users_list[i + 1] + " " + users_list[i + 2];
                    isAdmin = (users_list[i + 5]=="1");
                    try                                                                                         //исключение, если не выполнено то выполняется catch
                    {
                       email = users_list[i + 6];
                    }
                    catch(Exception) 
                    { }
                    Close();
                    return;
                }
            }
            MessageBox.Show("Данные введены неверно!");
        }
    }
}
