using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate class
            MyClass M1 = new MyClass();
            Console.WriteLine("Please enter a number.");
            // Convert user number and declare out integer
            int numOne = Convert.ToInt32(Console.ReadLine());
            int quot;
            // Call method and pass argument and out variable
            M1.NumDivide(numOne, out quot);
            Console.WriteLine(quot);

            Console.WriteLine("Please enter a second number to divide with.");
            // Convert second user number and declare second out integer
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int quot2;
            // Call overload method and pass two arguments and second out integer
            M1.NumDivide(numOne, numTwo, out quot2);
            Console.WriteLine(quot2);

            // Display constructors of static class
            Console.WriteLine(MyClass2.FirstName);
            Console.WriteLine(MyClass2.LastName);

            Console.ReadLine();
        }
    }
}
