using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee();
            Emp1.FirstName = "Sample";
            Emp1.LastName = "Student";
            Emp1.SayName();
            Console.ReadLine();
        }
    }
}
