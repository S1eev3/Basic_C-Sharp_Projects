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
            MyClass M1 = new MyClass();
            int result = M1.numMath(4);
            Console.WriteLine(result);

            MyClass M2 = new MyClass();
            int result2 = M1.numMath(2.5);
            Console.WriteLine(result2);

            MyClass M3 = new MyClass();
            int result3 = M1.numMath("2");
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
