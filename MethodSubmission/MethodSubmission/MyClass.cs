using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MethodSubmission
{
    class MyClass
    {
        public int numOne = 2;

        public int numMath(int userNumber1, [Optional] int userNumber2)
        {
            int numOne = 2;
            int result = numOne + userNumber1 + userNumber2;
            return result;
        }
    }
}
