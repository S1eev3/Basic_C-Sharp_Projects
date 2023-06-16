using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class MyClass
    {
        public void NumMath(int numOne, int numTwo)
        {
            int numThree = 3;
            int result = numOne + numThree;
            Console.WriteLine(numTwo);
            return;
        }
    }
}
