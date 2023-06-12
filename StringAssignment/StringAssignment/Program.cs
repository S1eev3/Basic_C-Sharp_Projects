using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Mitchal";
            string mName = "Dane Nuuhiwa";
            string lName = "Larson";

            Console.WriteLine("This is my full name, " + fName + ' ' + mName + ' ' + lName + '.');
            Console.WriteLine("Here is my first name in all capitals, " + fName.ToUpper() + '.');

            StringBuilder myParagraph = new StringBuilder();

            myParagraph.Append("This is my string builder paragraph.");
            myParagraph.Append("\nIt is built one line at a time.");
            myParagraph.Append("\nMy name is Mitch and I am 33 years old.");
            myParagraph.Append("\nMy birthday was last week and for it Blizzard released Diablo 4.");
            myParagraph.Append("\nWhich I have been awaiting for 11 years and was a great birthday present!");

            Console.WriteLine(myParagraph);

            Console.ReadLine();
        }
    }
}
