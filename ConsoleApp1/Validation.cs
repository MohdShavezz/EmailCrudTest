using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Validation
    {
        public static string CheckName(string name)
        {
            string regexPattern = @"^[A-Za-z]{3,}$";
            Regex regex = new Regex(regexPattern);
            while (!regex.IsMatch(name))
            {
                if (name == "q")
                {
                    return name;
                }
                Console.WriteLine("Enter Valid Data!!! or Go Back Press 'Q' ");
                name = Console.ReadLine();
                if (name == "Q")
                {
                    name = name.ToLower();
                }
            }
            return name;
        }
        public static string CheckMail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            while (!regex.IsMatch(email))
            {
                if (email == "q")
                {
                    return email;
                }
                Console.WriteLine("Enter Valid Data!!! or Go Back Press 'Q' ");
                email = Console.ReadLine();
                if (email == "Q")
                {
                    email = email.ToLower();
                }
            }
            return email;
        }
    
        public static string CheckId(List<Employee> Employees, string userIDUp)
        {

            while (!Employees.Any(e => e.ID == userIDUp))
            {
                if (userIDUp == "q")
                {
                    return userIDUp;
                }
                Console.WriteLine("Enter Valid Data!!! or Go Back Press 'Q' ");
                userIDUp = Console.ReadLine();
                if (userIDUp == "Q")
                {
                    userIDUp = userIDUp.ToLower();
                }
            }
            return userIDUp;
        }


    }
}
