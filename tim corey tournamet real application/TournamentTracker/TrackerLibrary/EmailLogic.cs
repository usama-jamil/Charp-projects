using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public static void SendEmail( string to , string subject , string body)
        {
            SendEmail(new List<string> { to }, null, subject, body);//yaha per new list<string>() replace kia hay null say
        }

        public static void SendEmail(List<string> to , List<string> bcc , string subject , string body)
        {
            var fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("senderDisplayName"));

            var mail = new MailMessage();

            foreach (var email in to)
            {
                mail.To.Add(email);
            }
            foreach (var email in bcc)
            {
                mail.Bcc.Add(email);
            }

            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            var client = new SmtpClient();

            client.Send(mail);
        }
    }
}
