using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace MedicLabStudyApplication
{
    public partial class ContactUsForm : Form
    {
        public ContactUsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //here on button click what will done 
                wyslij();
                MessageBox.Show("Wysłano wiadomość do MediLAB");
                //DisplayMessage.Visible = true;
                subjectTB.Text = "";
                mailTB.Text = "";
                nameTB.Text = "";
                questionRTB.Text = "";
            }
            catch (Exception) { }
        }


        public void wyslij()
        {

            SmtpClient smtpClient = new SmtpClient(); //tworzymy klienta smtp
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            MailMessage message = new MailMessage();//tworzymy wiadomość
            MailAddress from = new MailAddress(mailTB.Text, nameTB.Text);//adres nadawcy i nazwa nadawcy

            message.From = from;
            message.To.Add("projekt.zespolowy14@gmail.com");//adres odbiorcy
            message.Subject = subjectTB.Text;//temat wiadomości
            message.Body = questionRTB.Text + "\n\n" + mailTB.Text + " : " + nameTB.Text; //treść wiadomości
            smtpClient.Host = "smtp.gmail.com"; //host serwera
            smtpClient.Credentials = new System.Net.NetworkCredential("projekt.zespolowy14@gmail.com", "SilneHaslo");//nazwa nadawcy i hasło
            try
            {
                smtpClient.SendAsync(message, "nazwaOdbiorcy@gmail.com");//nazwa odbiorcy, wysyłamy wiadomość
            }
            catch (SmtpException ex)
            {

                throw new ApplicationException("Klient SMTP wywołał wyjątek. Sprawdź połączenie z internetem." + ex.Message);

            }
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
