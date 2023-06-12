using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarfieldDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop asking user to guess the cat Garfield
            // Since it is only a while loop and not do/while, the "correct" message will not display
            // if guessed right on the first try
            Console.WriteLine("Who is a famous cartoon cat that loves lasagna?");
            string cartoonCat = Console.ReadLine();
            bool catGuessed = cartoonCat == "Garfield";

            while (!catGuessed)
            {
                switch (cartoonCat)
                {
                    case "Garfield":
                        Console.WriteLine("Correct! Garfield the Cat loves Lasagna!");
                        catGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Who is a famous cartoon cat that loves lasagna?");
                        cartoonCat = Console.ReadLine();
                        break;
                }
            }



            Console.WriteLine("What day does Garfield the Cat hate most?");
            string garfieldDay = Console.ReadLine();
            bool dayGuessed = garfieldDay == "Monday";

            //Do while loop using switch statement asking user which day garfield hates even if user guesses right first try
            //not ideal since spelling errors or not capitalizing first letter causes error
            do
            {
                switch (garfieldDay)
                {
                    case "Sunday":
                        Console.WriteLine("You guessed Sunday. Try again.");
                        Console.WriteLine("What day does Garfield the Cat hate most?");
                        garfieldDay = Console.ReadLine();
                        break;
                    case "Monday":
                        Console.WriteLine("Correct! Garfield hates Mondays.");
                        dayGuessed = true;
                        break;
                    case "Tuesday":
                        Console.WriteLine("You guessed Tuesday. Try again.");
                        Console.WriteLine("What day does Garfield the Cat hate most?");
                        garfieldDay = Console.ReadLine();
                        break;
                    case "Wednesday":
                        Console.WriteLine("You guessed Wednesday. Try again.");
                        Console.WriteLine("What day does Garfield the Cat hate most?");
                        garfieldDay = Console.ReadLine();
                        break;
                    case "Thursday":
                        Console.WriteLine("You guessed Thursday. Try again.");
                        Console.WriteLine("What day does Garfield the Cat hate most?");
                        garfieldDay = Console.ReadLine();
                        break;
                    case "Friday":
                        Console.WriteLine("You guessed Friday. Try again.");
                        Console.WriteLine("What day does Garfield the Cat hate most?");
                        garfieldDay = Console.ReadLine();
                        break;
                    case "Saturday":
                        Console.WriteLine("You guessed Saturday. Try again.");
                        Console.WriteLine("What day does Garfield the Cat hate most?");
                        garfieldDay = Console.ReadLine();
                        break;
                }
            }
            while (!dayGuessed);

            Console.ReadLine();
        }
    }
}
