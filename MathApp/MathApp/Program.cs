using System;

namespace MathApp
{
    class Program
    {
        static void Main()
        {
            // Takes input from user and multiplies it by 50 after converting string to double
            Console.WriteLine("Please give me a number");
            string num1 = Console.ReadLine();
            double num50 = Convert.ToDouble(num1);
            Console.WriteLine("Here is your number multiplied by 50: " + num50 * 50);

            // Takes input from user and adds 25 to it after converting string to double
            Console.WriteLine("Please give me another number");
            string num2 = Console.ReadLine();
            double num25 = Convert.ToDouble(num2);
            Console.WriteLine("Here is your number with 25 added: ");
            Console.WriteLine(num25 + 25);

            // Takes input from user and divides it by 12.5 after converting string to double
            Console.WriteLine("I need yet another number");
            string num3 = Console.ReadLine();
            double num125 = Convert.ToDouble(num3);
            Console.WriteLine("Here is your number divided by 12.5 : ");
            Console.WriteLine(num125 / 12.5);

            // Takes input from user and tests if it is greater than 50 after converting string to double
            Console.WriteLine("Give me another one");
            string num4 = Console.ReadLine();
            double numg = Convert.ToDouble(num4);
            Console.WriteLine("Is your number greater than 50?");
            Console.WriteLine(numg > 50);

            // Takes input from user and displays remainder when dividing it by 7 after converting string to double
            Console.WriteLine("One more number please");
            string num5 = Console.ReadLine();
            double num7 = Convert.ToDouble(num5);
            Console.WriteLine("Here is the remainder of your number when divided by 7:");
            Console.WriteLine(num7 % 7);
            
            Console.ReadLine();
        }
    }
}
