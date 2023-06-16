using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = MyClass.numMath(4);
            Console.WriteLine(result);
            int result2 = MyClass.numMath(4, 2.5);
            Console.WriteLine(result2);
            int result3 = MyClass.numMath("2");
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
