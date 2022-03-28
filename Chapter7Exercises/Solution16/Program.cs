using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element {0} of the array: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter searched number: ");
            int numnber = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(array, numnber);
            if (index >= 0)
            {
                Console.Write("Number is index {0}", index);

            }
            else
            {
                Console.WriteLine("Number does not exist");
            }

            Console.ReadKey();
        }
    }
}
