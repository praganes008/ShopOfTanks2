using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOfTanks
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            //адрес исходника(от кого)
            MailAddress fromAdress = new MailAddress("serzh.povorov.95@mail.ru");

            //адрес кому
            MailAddress toAdress = new MailAddress("serzh.povorov.95@mail.ru");

            //тема письма


            //текст письма


        }
    }
}
