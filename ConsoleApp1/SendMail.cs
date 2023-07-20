using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    internal class SendMail
    {
        private List<Employee> employees;

        public SendMail(List<Employee> Employees)
        {
            if (Employees.Count == 0)
            {
                Console.WriteLine("No Records!!! Kindly Add Authentic Data.");
            }
            else
            {
                Console.WriteLine("Enter Emial-ID to Send Email : ");
                string IdMail = Console.ReadLine();
                IdMail=Validation.CheckId(Employees, IdMail);
                if (IdMail == "q")
                {
                    return;
                }
                string MailTo = Employees.Where(e => e.ID == IdMail).Select(e => e.Mail).FirstOrDefault().ToString();
                Console.WriteLine("Your Email Subject");
                string subject = Console.ReadLine();
                Console.WriteLine("Your Email Body");
                string body = Console.ReadLine();

                Mailing.SendEmail(MailTo,subject,body);
                Console.WriteLine("Mail sent to {0} !!!",MailTo);
                Console.ReadLine();
            }
        }
    }
}