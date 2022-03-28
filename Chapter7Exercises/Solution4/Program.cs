using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K, where K is less than N: ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element{0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array, (a, b) => b.CompareTo(a));
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("\nhighest sum = {0}", sum);

            Console.ReadKey();
        }
    }
}
