using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class secondhig
    {
        public static void Main()
        {
            int[] array = { 100, 200, 300, 400, 500, 600, 700,};
            Array.Sort(array); //sorting array  
            Array.Reverse(array); // Reverse Sorting array value  
            Console.WriteLine("Second Highest Value In Array " + array[1]);

            foreach (var result in array)
            {
                Console.Write(result + " "); // Array values   
            }
        }
    }

}
