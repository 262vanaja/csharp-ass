using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class _2b
    {
        public static void swap(ref int a, ref int b)
        {
            int t = a;
            a = b; b = t;
            Console.WriteLine($"a={a},b={b}");
        }


        public static void Main()
        {


            int a = 5;
            int b = 4;

            Console.WriteLine($"beforw swap a={a},b={b}");

            swap(ref a, ref b);
            Console.WriteLine($"after  swap a={a},b={b}");
        }

    }
}
