using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;



class Program
{
    static void Main(string[] args)
    {
        //Assignment Part 1

        string[] names = { "Mitchal", "Ashtyn", "James", "Jessica" };

        // Asks user to supply last name and saves it as variable lastName
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        // Iterates through each string in the array and adds lastName variable to each string
        for(int i = 0; i < names.Length; i++)
        {
            names[i] = names[i] + " " + lastName;
        }

        // Iterates through each new string in the array and prints it to console
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }

        Console.ReadLine();

        // Assignment Part 2

        // Created an infinite loop where initially lies never evaluated to false
        // Fixed the infinite loop by changing lies to false after printing to the console once
        bool lies = true;
        while (lies)
        {
            Console.WriteLine("I must not tell lies");
            lies = false;
        }

        Console.ReadLine();

        //Assignment Part 3

        int[] childWeight = { 85, 90, 100, 110, 115 };

        // For loop with a counter using < operator to determine if a child weighs enough to paraglide
        for (int i = 0; i < childWeight.Length; i++)
        {
            if (childWeight[i] >= 100)
            {
                Console.WriteLine("You are able to paraglide because you weigh 100lbs or more: " + childWeight[i]);
            }
        }
        Console.ReadLine();


        int[] testScores = { 99, 95, 92, 90, 85, 82, 80, 75, 70, 69, 65, 62 };
        
        // Foreach loop using <= operator to determine if a student has failed an assignment with a score at or below 70
        foreach(int score in testScores)
        {
            if(score <= 70)
            {
                Console.WriteLine("I'm sorry you have failed this assignment with a score of: " + score);
            }
        }
        Console.ReadLine();

        //Assignment Part 4

        List<string> cities = new List<string>() { "Denver", "Dallas", "Seattle", "Columbus", "Bozeman" };

        // Asks user to input a city and saves it as string variable userCity
        Console.WriteLine("Please enter a city you would like to work in to see if it is available: ");
        string userCity = Console.ReadLine();

        // foreach loop to iterate through cities and find a match
        foreach(string city in cities)
        {
            if (userCity == city)
            {
                Console.WriteLine("There is availability in: " + city);
                break;
            }
            // Message if given city is not on the list
            // I really don't like how this works becasue it does it for EVERY item in the list even if it hasn't been iterated to yet
            // I tried doing this as a for loop instead, or with the error message being else and not else if and still ended up with the same result
            // Would love some feedback and a way to state the else if message ONLY if it's not found and not if it's cause the
            // first or second items aren't a match
            // Also if given a city not on the list it states this message 4 times and not just once.
            // I still can't figure it out or find a different way to do it where it's only stated once

            // UPDATE: I found a way to do what I was wanting to do with this assignment in the following assignment
            // but did not yet go back and adjust this one to do the same
            // I hope that is ok and this works for what was needed
            else if (userCity != city)
            {
                Console.WriteLine("Your chosen City is not on the list");
            }
        }

        Console.ReadLine();


        //Assignment Part 5

        List<string> fNames = new List<string>() { "Adam", "Daniel", "Adam", "James", "Adam" };

        //Asks user to give a name to search the list for and saves as variable givenName
        Console.WriteLine("Please enter a first name to seach for: ");
        string givenName = Console.ReadLine();

        // Starts a for loop to search through the list for the givenName
        bool nameGuess = false;
        for(int index = 0; index<fNames.Count; index++)
        {
            string fName = fNames[index];
            
            // Displays index of ALL matches for the givenName
            if (fName == givenName)
            {
                nameGuess = true;
                Console.WriteLine("The name \"{0}\" had a match at index {1}", fName, index);
            }
        }
        // Message if there were no matches for that name
        if (nameGuess == false)
        {
            Console.WriteLine("There were no matches for that name.");
        }
        // Message to tell user there was at least one match for givenName
        else
        {
            Console.WriteLine("There is at least 1 match with the following name: " + givenName);
        }

        Console.ReadLine();


        // Assignment Part 6
        // THIS ONE REALLY HAD ME FOR AWHILE BUT I FINALLY GOT IT

        // String list with duplicate items
        List<string> Mountains = new List<string>() { "Keystone", "Arapahoe", "Copper", "Breckenridge", "Copper", "Keystone" };

        // Creates new list of unique strings
        List<string> unique = Mountains.Distinct().ToList();

        // Creates second list of duplicate strings
        List<string> duplicate = Mountains.GroupBy(x => x)
                                 .Where(x => x.Count() > 1)
                                 .Select(x => x.Key)
                                 .ToList();

        // Foreach loop to display list of unique strings only
        unique.ForEach(i => Console.WriteLine($"{i}" + " - This item is unique"));

        // Foreach loop to display only duplicate strings
        foreach (var dup in duplicate)
        {
            Console.WriteLine(string.Join(System.Environment.NewLine, dup) + " - This item is a duplicate");
        }

        

        



        Console.ReadLine();
    }
}

