using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDR
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();   // Store returned name as variable with string value
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine(); // Store returned course as variable with string value
            Console.WriteLine("What page number are you on?");
            string yourPageNumber = Console.ReadLine(); // Store returned page number as string value
            int yourPage = Convert.ToInt32(yourPageNumber); // Convert returned string to int value
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string helpNeeded = Console.ReadLine(); // Store answer as variable with string value
            bool helpNeed = Convert.ToBoolean(helpNeeded);  //Convert returned string to bool value

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourEXP = Console.ReadLine();    // Store answer as variable with string value
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string yourFeed = Console.ReadLine();   // Store answer as variable with string value
            Console.WriteLine("How many hours did you study today?");
            string yourHours = Console.ReadLine();  // Store answer as variable with string value
            int yourHour = Convert.ToInt32(yourHours);  // Convert returned string to int value

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}