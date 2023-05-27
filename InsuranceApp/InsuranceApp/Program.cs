using System;

namespace InsuranceApp
{
    class Program
    {
        static void Main()
        {
            // Retrieve users age and convert string to int
            Console.WriteLine("What is your age?");
            string yearsold = Console.ReadLine();
            int age = Convert.ToInt32(yearsold);

            // Retrieve users dui status and convert string to bool
            Console.WriteLine("Have you ever had a DUI? true or false");
            string duiyn = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiyn);

            // Retrieve users tickets amount and convert string to int
            Console.WriteLine("How many speeding tickets do you have?");
            string sptick = Console.ReadLine();
            int ticks = Convert.ToInt32(sptick);

            //Calculate whether user is qualified for insurance with age greater than 15, dui = false, and tickets no more than 3
            Console.WriteLine("Are you qualified for insurance?");
            bool qualify = (age > 15 && dui == false && ticks <= 3);
            Console.WriteLine(qualify);

            Console.ReadLine();
        }
    }
}
