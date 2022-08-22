using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class vowles
    {
        public static bool isVowel(char x)
        {
            x = char.ToUpper(x);
            return (x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U');
        }

        public static int countVowels(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (isVowel(str[i]))
                {
                    ++count;
                }
            }
            return count;
        }

        public static void Main(string[] args)
        {

            string str = "bujji";

            Console.WriteLine(countVowels(str));
        }
    }
}
