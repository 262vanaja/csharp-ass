using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class max
    {
        static void Main()
        {
            int[] Arr = { 222, -100, -307, 0, 1555, 108, 305 };
            Console.WriteLine("Maximum Element : " + Arr.Max());
            Console.WriteLine("Minimum Element : " + Arr.Min());
            Console.Read();
        }
    }
}
