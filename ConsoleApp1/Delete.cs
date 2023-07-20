using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Delete
    {
        public Delete(List<Employee> Employees)
        {
            if (Employees.Count == 0)
            {
                Console.WriteLine("No Records!!! Kindly Add Authentic Data.");
            }
            else
            {
                Console.WriteLine("enter Email-ID to Delete: ");
                string userIdDel = Console.ReadLine();
                Validation.CheckId(Employees, userIdDel);
                Employees.RemoveAll(e => e.ID == userIdDel);
                Console.WriteLine("ID :{0} Deleted sucessfully!!!", userIdDel);
                Console.WriteLine("---------------------------");
            }

        }
    }
}
