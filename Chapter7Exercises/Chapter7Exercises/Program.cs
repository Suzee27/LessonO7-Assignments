using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // solution 1
            int[] elements = new int[20];

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = i * 5;
                Console.WriteLine("Element {0}: {1} ", i, elements[i]);
              
            }

            Console.ReadKey();
        }
    }
}
