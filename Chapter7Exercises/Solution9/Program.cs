using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution9
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

            int sum = 0;
            int isum = 0;
            for (int i = 0; i < length - 1; i++)
            {
                isum = array[i];
                for (int j = i + 1; j < length; j++)
                {
                    isum += array[j];
                    if (isum > sum)
                    {
                        sum = isum;
                    }
                }
            }
            Console.WriteLine("The maximal sum = " + sum);
            Console.ReadKey();
        }
    }
}
