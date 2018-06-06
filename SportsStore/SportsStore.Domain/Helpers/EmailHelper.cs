using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace SportsStore.Domain.Helpers
{
    class EmailHelper
    {
        public void Send(
            string subject,
            string receiver,
            string body,
            IList<string> cc,
            IList<string> bcc)
        {
            using(var smtpClient = new SmtpClient())
            {
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("ttdiep127@gmail.com", "zmuiezetlfmqcmam");
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;

                MailMessage message = new MailMessage();
                message.From = new MailAddress("ttdiep127@gmail.com");
                message.To.Add(receiver);

                if (cc != null)
                {
                    foreach(var c in cc)
                    {
                        message.CC.Add(c);
                    }
                }

                if (bcc != null)
                {
                    foreach (var b in bcc)
                    {
                        message.Bcc.Add(b);
                    }
                }

                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                smtpClient.Send(message);
            }
        }
    }
}
