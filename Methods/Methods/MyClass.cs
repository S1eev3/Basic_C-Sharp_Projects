using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class MyClass
    {
        public static int MathAdd(int userNumber)
        {
            int numberOne = 2;
            int resultAdd = numberOne + userNumber;
            return resultAdd;
        }

        public static int MathMultiply(int userNumber)
        {
            int numberOne = 2;
            int resultMultiply = numberOne * userNumber;
            return resultMultiply;
        }

        public static int MathDivide(int userNumber)
        {
            int numberOne = 2;
            int resultDivide = userNumber / numberOne;
            return resultDivide;
        }
    }
}
