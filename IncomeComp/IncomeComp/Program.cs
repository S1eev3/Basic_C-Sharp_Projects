using System;

namespace IncomeComp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string P1rate = Console.ReadLine();
            int P1HR = Convert.ToInt32(P1rate);
            Console.WriteLine("Hours worked per week?");
            string P1hours = Console.ReadLine();
            int P1HW = Convert.ToInt32(P1hours);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string P2rate = Console.ReadLine();
            int P2HR = Convert.ToInt32(P2rate);
            Console.WriteLine("Hours worked per week?");
            string P2hours = Console.ReadLine();
            int P2HW = Convert.ToInt32(P2hours);

            Console.WriteLine("Annual Salary of Person 1:");
            decimal P1Annual = ((P1HR * P1HW) * 52);
            Console.WriteLine(string.Format("{0:n0}", P1Annual));

            Console.WriteLine("Annual Salary of Person 2:");
            decimal P2Annual = ((P2HR * P2HW) * 52);
            Console.WriteLine(string.Format("{0:n0}", P2Annual));

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(P1Annual > P2Annual);


            Console.ReadLine();
        }
    }
}
