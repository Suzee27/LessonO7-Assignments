using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the first array: ");
            int lengthA = int.Parse(Console.ReadLine());
            int[] firstArray = new int[lengthA];

            Console.Write("Enter the length of the second array: ");
            int lengthB = int.Parse(Console.ReadLine());
            int[] secondArray = new int[lengthB];

            for (int i = 0; i < lengthA; i++)
            {
                Console.Write("Enter element {0} of the first array: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < lengthB; i++)
            {
                Console.Write("Enter element {0}: of the second array ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < lengthB; i++)
            {
                if (lengthA == lengthB && (firstArray[i] == secondArray[i]))
                {
                    Console.WriteLine("Arrays are the same");
                    break;
                }
                else
                {
                    Console.WriteLine("Arrays are different");
                }
            }
            Console.ReadKey();
        }
    }
}
