using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MedicLabStudyApplication.Libs.Email
{
    class Email
    {
        public static void send(String inputName, String inputEmail, String inputSubject, String inputQuestion)
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            MailMessage message = new MailMessage();
            MailAddress from = new MailAddress(inputEmail, inputName);

            message.From = from;
            message.To.Add("projekt.zespolowy14@gmail.com");
            message.Subject = inputSubject;
            message.Body = inputQuestion + "\n\n" + inputEmail + " : " + inputName;
            smtpClient.Host = "smtp.gmail.com"; //host serwera
            smtpClient.Credentials = new System.Net.NetworkCredential("projekt.zespolowy14@gmail.com", "SilneHaslo");
            try
            {
                smtpClient.SendAsync(message, "projekt.zespolowy14@gmail.com");
            }
            catch (SmtpException ex)
            {
                throw new ApplicationException("Klient SMTP wywołał wyjątek. Sprawdź połączenie z internetem." + ex.Message);
            }
        }
    }
}
