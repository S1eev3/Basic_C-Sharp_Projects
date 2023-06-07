using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)    
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);    //If package weighs more than 50 will display message and end program
            }

            Console.WriteLine("Please enter the package width:");   //Gets width from user and converts to Int
            int packWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");  //Gets height from user and converts to Int
            int packHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");  //Gets length from user and converts to Int
            int packLength = Convert.ToInt32(Console.ReadLine());

            if ((packWidth + packHeight + packLength) > 50) //If statement to check whether sum of dimensions is greater than 50
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);    //If any package dimensions are greater than 50 will display message and end program
            }

            int packResult = (packHeight*packWidth*packLength)*packWeight/100;  //Calculates package dimensions and quote
            Console.WriteLine("Your estimated total for shipping this package is: " + packResult.ToString("C"));    //Displays quote message and result as currency
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
