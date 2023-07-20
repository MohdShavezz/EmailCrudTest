using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Add
    {
        public Add(List<Employee> Employees)
        {

            Console.WriteLine("enter Name :");
            string userNameAdd= Console.ReadLine();
            userNameAdd=Validation.CheckName(userNameAdd);
            userNameAdd=userNameAdd.ToLower();
            if (userNameAdd == "q")
            {
                return;
            }

            Console.WriteLine("enter Email : ");
            string userMailAdd= Console.ReadLine();
            userMailAdd=Validation.CheckMail(userMailAdd);
            userMailAdd =userMailAdd.ToLower();            
            if (userMailAdd == "q")
            {
                return;
            }

            if (!Employees.Any(e => e.Mail == userMailAdd))     // if Exists Email 
            {
                Program.AddEmployee(Employees, userNameAdd, userMailAdd);
                Console.WriteLine("Added Successfully!!!");
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.WriteLine(  "Email Already Exists !!!");
            }
            
     
        }
    }
}
