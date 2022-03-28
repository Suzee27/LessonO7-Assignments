using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution10
{
    class Program
    {
        static void Main(string[] args)
        {
            // most occuring number
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element {0} of the array: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            int count = 1;
            int number = 0;
            int icount = 0;

            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] == array[i+ 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > icount)
                {
                    icount = count;
                    number = array[i];
                }
            }

            Console.WriteLine("most occuring number is {0} for {1} times", number, icount );
            Console.ReadKey();
        }
    }
}
