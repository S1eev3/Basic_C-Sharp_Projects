using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // List of integers to be used to divide againt userNumber
        List<int> divideNumbers = new List<int>() { 4, 8, 12, 16 };

        // Try catch block handle exceptions
        try
        {
            // Retrieve number from user and convert to int
            Console.WriteLine("Please supply a number to be used to divide other numbers with.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Foreach loop to divide userNumber against divideNumber list
            foreach (int num in divideNumbers)
            {
                int result = num / userNumber;
                Console.WriteLine(num + " divided by " + userNumber + " equals " + result);
            }
        }
        // catch block for format exception
        catch(FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
        }
        //catch block for dividebyzero exception
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        // catch block for any other exceptions
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // finally block to ensure messages are displayed
        finally
        {
            Console.ReadLine();
        }
        // Final message to user to display that program has completed
        Console.WriteLine("This program has completed execution.");
        Console.ReadLine();








    }
}

