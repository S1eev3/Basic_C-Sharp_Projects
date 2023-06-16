using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass M1 = new MyClass();
            int numOne = 1;
            int numTwo = 2;
            M1.NumMath(numOne, numTwo);
            M1.NumMath(numOne: 1, numTwo: 2);
            Console.ReadLine();
        }
    }
}
