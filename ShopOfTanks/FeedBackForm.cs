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
            if (TopicCB.Text == "")
            {
                MessageBox.Show("Поле ТЕМА обязательно к заполнению!");
            }
            else
            {

                //адрес кому
                MailAddress toAdress = new MailAddress("serzh.povorov.95@mail.ru");
                //формирование письма
                using (MailMessage mailMessage = new MailMessage(fromAdress, toAdress))
                using (SmtpClient smtpClient = new SmtpClient())                                                             //смтп - отправка сообщенийй
                {
                    //тема письма
                    mailMessage.Subject = TopicCB.Text;                                                                         //присвоение темы письму из комбобокса
                                                                                                                                //тело(текст) письма                                                                                                            //текст письма
                    mailMessage.Body = MessageTB.Text;
                    mailMessage.IsBodyHtml = true;                                                                                  //при формировании сообщ. текст письма будет представлен в html

                    smtpClient.Host = "smtp.mail.ru";         //берётся из самого "ящика"
                    smtpClient.Port = 587;                    //берётся из самого "ящика" 
                    smtpClient.EnableSsl = true;                                                                             //метод шифрования, конфидециальность...
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;                                                      //метод отправки
                    smtpClient.UseDefaultCredentials = false;                                                                        //тоже безопасность
                    smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "erfHctFyUSzczxkna0cw");                                      //откуда будет отправляться, а второй параметр это пароль, который генерируется в самом почтовом ящике в разделе"безопасность"
                    smtpClient.Send(mailMessage);                                                                               //отправка письма 
                }
                MessageBox.Show("Сообщение успешно отправлено!");
                Close();
            }

        }
    }
}
