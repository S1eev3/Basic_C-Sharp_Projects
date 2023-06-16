using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number you would like to perform math operations with.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int resultAdd = MyClass.MathAdd(userNumber);
            Console.WriteLine("2" + " plus " + userNumber + " equals " + resultAdd);
            int resultMultiply = MyClass.MathMultiply(userNumber);
            Console.WriteLine("2" + " times " + userNumber + " equals " + resultMultiply);
            int resultDivide = MyClass.MathDivide(userNumber);
            Console.WriteLine(userNumber + " divided by " + "2" + " equals " + resultDivide);

            Console.ReadLine();
        }
    }
}
