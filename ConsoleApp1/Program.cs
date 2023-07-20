using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Employee
    {
        public string ID = Guid.NewGuid().ToString("N").Substring(0, 8);
        public string Name;
        public string Mail;
        public Employee(string name, string mail)
        {
            Name = name;
            Mail = mail;
        }
    }
    public class Program
    {
        public static void ShowEmployees(List<Employee> Employees)
        {
            if (Employees.Count == 0)
            {
                Console.WriteLine("No Records!!! Kindly Add Records.");
            }
            else
            {
                foreach (var i in Employees)
                {
                    Console.WriteLine("{0} {1} {2}", i.ID, i.Name, i.Mail);
                }
            }
        }

        public static void AddEmployee(List<Employee> Employees, string name, string mail)
        {
            Employees.Add(new Employee(name, mail));
        }

        public static void Main(string[] args)
        {
            var Employees = new List<Employee>
            {
                //new Employee("shavez","shaveza493@gmail.com"),
            };



            while (true)
            { 
                Console.WriteLine("Show Records: press 'S'");
                Console.WriteLine("Add Record : press 'A'");
                Console.WriteLine("Update by Emial-Id : press 'U'");
                Console.WriteLine("Delete by Emial-Id : press 'D'");
                Console.WriteLine("Send Email : press 'M'");
                Console.WriteLine("Broadcast E-Mail to All Employees : press 'SM'");
                Console.WriteLine("Exit : press 'E'");
                string UserChoise = Console.ReadLine();
                UserChoise=UserChoise.ToLower();
                if (UserChoise == "a")
                {
                    new Add(Employees);
                }
                else if (UserChoise == "u")
                {
                    new Update(Employees);
                }
                else if (UserChoise == "d")
                {
                    new Delete(Employees);

                }
                else if (UserChoise == "m")
                {
                    new SendMail(Employees);

                }
                else if (UserChoise == "s")
                {
                    Console.WriteLine("-------------------------");
                    ShowEmployees(Employees);
                    Console.WriteLine("-------------------------");
                }                
                else if (UserChoise == "sm")
                {
                    // email broadscasting
                    new Mailing(Employees);
                    Console.ReadLine();
                }
                else if (UserChoise == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }




        }
    }
}