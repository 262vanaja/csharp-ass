using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class @string
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("bujji"));
            Console.WriteLine(first_last("sundaram"));
            Console.WriteLine(first_last("vanu"));
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}
