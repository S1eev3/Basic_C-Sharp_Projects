using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = { "One String", "Two String", "Red String", "Blue String" };

        int[] intArray = { 5, 10, 15, 20 };

        List<string> stringList = new List<string>();
        stringList.Add("One String");
        stringList.Add("Two String");
        stringList.Add("Red String");
        stringList.Add("Blue String");


        Console.WriteLine("There are 4 strings in the array, enter a number between 0-3 to display one of them.");
        int stringSelect = Convert.ToInt32(Console.ReadLine());

        if (stringSelect <= 3)
        {
            Console.WriteLine(stringArray[stringSelect]);
        }
        else
        {
            Console.WriteLine("Please select a number between 0 and 3");
            Console.WriteLine("There are 4 strings in the array, enter a number 0-3 to display one of them.");
            stringSelect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray[stringSelect]);
        }


        Console.WriteLine("There are 4 numbers in the next array, pick a number 0-3 to display one of them.");
        int intSelect = Convert.ToInt32(Console.ReadLine());

        if (intSelect <=3)
        {
            Console.WriteLine(intArray[intSelect]);
        }
        else
        {
            Console.WriteLine("Please select a number between 0 and 3");
            Console.WriteLine("There are 4 numbers in the next array, pick a number 0-3 to display one of them.");
            intSelect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intArray[intSelect]);
        }

        Console.WriteLine("There are 4 strings in the list, enter a number between 0-3 to display one of them.");

        int stringSelect2 = Convert.ToInt32(Console.ReadLine());

        if (stringSelect2 <= 3)
        {
            Console.WriteLine(stringList[stringSelect2]);
        }
        else
        {
            Console.WriteLine("Please select a number between 0 and 3");
            Console.WriteLine("There are 4 strings in the list, enter a number 0-3 to display one of them.");
            stringSelect2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[stringSelect2]);
        }


        Console.ReadLine();
    }
}

