using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace MachineAnalyzer.Classes
{
    class Mails
    {
        private readonly string From = "email";
        private readonly string Password = "password";
        public Int16 Port = 587;
        public bool EnableSsl = true;
        public bool IsBodyHTML = true;

        public void Send(string to, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
                mail.From = new MailAddress(this.From);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = this.IsBodyHTML;

                SmtpServer.Port = this.Port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(this.From, this.Password);
                SmtpServer.EnableSsl = this.EnableSsl;

                SmtpServer.Send(mail);
            }
            catch
            {
                
            }
        }
    }
}
