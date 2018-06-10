using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class Test : ICloneable
        {
            public int a = 0;
            public int b = 2;

            public object Clone()
            {
                return MemberwiseClone();
            }

            public override string ToString()
            {
                return $"{a}, {b}";
            }
        }

        static void Main(string[] args)
        {
            var test1 = new Test();
            var test2 = (Test)test1.Clone();
            test2.a = 5;
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine("Good Bye!");
        }
    }
}
