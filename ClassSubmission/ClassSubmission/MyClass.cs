using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class MyClass
    {
        // Void method to divide given number by 2
        public void NumDivide(int numOne, out int result)
        {
            result = numOne / 2;
        }

        // Void overload method to divide two given numbers
        public void NumDivide(int numOne, int numTwo, out int result2)
        {
            result2 = numOne / numTwo;
        }
    }
}
