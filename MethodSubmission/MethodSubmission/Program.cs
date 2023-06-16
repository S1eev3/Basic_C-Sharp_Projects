using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass M1 = new MyClass();
            Console.WriteLine("Please supply a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // While loop to determine if user supplied 2nd number
            while (true)
            {
                Console.WriteLine("If you would like to please supply another number, this is not required.");
                string userInput = Console.ReadLine();

                // Executes if entry is null and continues without optional argument
                if (string.IsNullOrEmpty(userInput))
                {
                    int result2 = M1.numMath(userNumber);
                    Console.WriteLine(result2);
                    break;
                }
                // When user supplies 2nd number method executes with the optional argument
                else
                {
                    int userNumber2 = Convert.ToInt32(userInput);
                    int result = M1.numMath(userNumber, userNumber2);
                    Console.WriteLine(result);
                    break;
                }

            }


            Console.ReadLine();
        }
    }
}
