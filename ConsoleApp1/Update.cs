using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Update
    {
        public Update(List<Employee> Employees)
        {
            if (Employees.Count == 0)
            {
                Console.WriteLine("No Records!!! Kindly Add Authentic Data.");
            }
            else
            {
                Console.WriteLine("enter Email-ID to Update: ");
                string userID = Console.ReadLine();
                userID=Validation.CheckId(Employees, userID);
                userID=userID.ToLower();
                if (userID == "q")
                {
                    return;
                }

                Console.WriteLine("enter Name : ");
                string userName = Console.ReadLine();
                userName = Validation.CheckName(userName);
                userName=userName.ToLower();
                if (userName == "q")
                {
                    return;
                }

                Console.WriteLine("enter Email : ");
                string userMail = Console.ReadLine();
                userMail = Validation.CheckMail(userMail);
                userMail= userMail.ToLower();  
                if (userMail == "q")
                {
                    return;
                }

                foreach (var i in Employees.Where(emp => emp.ID == userID))
                {
                    i.Name = userName;
                    i.Mail = userMail;
                }
                Console.WriteLine("updated Successfully!!!");
                Console.WriteLine("---------------------------");
            }


        }
    }
}
