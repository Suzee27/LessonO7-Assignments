using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution8
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
                array[i] =int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length-1; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                    else
                    {
                        array[i] = array[i];
                        array[i + 1] = array[i + 1];
                    }
                }
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("element {0} = {1}", i, array[i]);
            }
            Console.ReadKey();
        }
    }
}
