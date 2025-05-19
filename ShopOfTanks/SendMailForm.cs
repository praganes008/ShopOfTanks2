using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOfTanks
{
    public partial class SendMailForm : Form
    {
        public SendMailForm()
        {
            InitializeComponent();
            AdressTB.Text = AusForm.email;
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            //адрес исходника(от кого)
            MailAddress fromAdress = new MailAddress("serzh.povorov.95@mail.ru");
            if (AdressTB.Text == "")
            {
                MessageBox.Show("Это поле обязательно к заполнению!");
            }
            else
            {

                //адрес кому
                MailAddress toAdress = new MailAddress(AdressTB.Text);
                //формирование письма
                using (MailMessage mailMessage = new MailMessage(fromAdress, toAdress))
                using (SmtpClient smtpClient = new SmtpClient())                                                                                                    //смтп - отправка сообщенийй
                {
                    //тема письма
                    mailMessage.Subject = "Список избранных товаров магазина: ShOT";                                                                         //присвоение темы письму из комбобокса
                                                                                                                                                             //тело(текст) письма                                                                                                            //текст письма
                    mailMessage.Body = "Здравствуйте, " + AusForm.username + Environment.NewLine + "мы прислали вам список избранных товаров онлайн магазина: ShOT";
                    mailMessage.IsBodyHtml = true;                                                                                                              //при формировании сообщ. текст письма будет представлен в html

                    System.IO.File.AppendAllText("Избранное.csv", "Название,Количесво,Цена");
                    foreach (KeyValuePair<Product, int> select_product in SelectedForm.selectProduct)
                    {
                        Product product = select_product.Key;
                        System.IO.File.AppendAllText("Избранное_" + AusForm.username + ".csv", Environment.NewLine + product.name + "," + select_product.Value + "," + product.price);
                    }

                    System.IO.File.AppendAllText("Избранное_" + AusForm.username + ".csv", Environment.NewLine + "Общая стоимость:" + SelectedForm.TotalPrice);

                    mailMessage.Attachments.Add(new Attachment("Избранное_" + AusForm.username + ".csv"));

                    smtpClient.Host = "smtp.mail.ru";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "erfHctFyUSzczxkna0cw");
                    smtpClient.Send(mailMessage);
                }
                MessageBox.Show("Сообщение успешно отправлено!");
                Close();
            }
        }
    }
}
