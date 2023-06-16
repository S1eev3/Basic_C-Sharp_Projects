using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MyClass
    {
        public int numOne = 2;
        public int numMath(int userNumber)
        {
            int numOne = 2;
            int result = numOne + userNumber;
            return result;
        }

        public int numMath(double decNumber)
        {
            double numOne = 2;
            double result = numOne * decNumber;
            int result2 = Convert.ToInt32(result);
            return result2;
        }

        public int numMath(string userNumber)
        {
            int numOne = 20;
            int userNumber2 = Convert.ToInt32(userNumber);
            int result3 = numOne / userNumber2;
            return result3;
        }
    }
}
