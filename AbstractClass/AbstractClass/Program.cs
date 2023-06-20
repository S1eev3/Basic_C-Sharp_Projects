using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee();
            Emp1.firstName = "Sample";
            Emp1.lastName = "Student";
            Emp1.SayName();
            Console.ReadLine();
        }
    }
}
