using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Mailing
    {
        private List<Employee> employees;

        public Mailing(List<Employee> employees)
        {
            string[] Emails = employees.Select(e=>e.Mail).ToArray() ;
            Console.WriteLine("Your Email Subject");
            string subject = Console.ReadLine();
            Console.WriteLine("Your Email Body");
            string body = Console.ReadLine();

            BroadcastEmails(Emails, subject, body);

            Console.WriteLine("Email broadcast completed.");
        }

        private void BroadcastEmails(string[] Emails, string subject, string body)
        {
            var tasks = new List<Task>();

            foreach (var Email in Emails)
            {
                tasks.Add(Task.Run(() => SendEmail(Email, subject, body)));
            }

            Task.WaitAll(tasks.ToArray());
        }
        public static void SendEmail(string to, string subject, string body)
        {
            string fromAddress = "mohdpctebtech19cse@gmail.com"; 
            string password = "wsqhpdopbgvzjree"; 

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromAddress);
            message.To.Add(to);
            message.Subject = subject;
            message.Body = body;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); 
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAddress, password);
            smtpClient.EnableSsl = true;

            smtpClient.Send(message);
        }

    }
}