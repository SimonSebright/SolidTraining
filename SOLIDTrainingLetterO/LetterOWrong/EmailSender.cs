using System;
using System.Net;
using System.Net.Mail;

namespace LetterOWrong
{
    internal class EmailSender
    {
        public void SendMail(string to, string subject, string body)
        {
            var mailMessage = BuildMailMessage(to, subject, body);
            SendMessage(mailMessage);
        }

        private static void SendMessage(MailMessage mailMessage)
        {
            Console.WriteLine();
            Console.WriteLine($"Sending message from:{mailMessage.From}, to:{mailMessage.To}, subject:{mailMessage.Subject}, body:{mailMessage.Body}");

            // Access: https://mailtrap.io/
            // UName: christoph.koenig@isolutions.ch
            // PW: 123456
            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("2e5239bd361ded", "c92461365296ff"),
                EnableSsl = true
            };

           client.Send(mailMessage);
        }

        private static MailMessage BuildMailMessage(string to, string subject, string body)
        {
            return new MailMessage("solid@isolutions.ch", to)
            {
                Body = body,
                Subject = subject
            };
        }
    }
}