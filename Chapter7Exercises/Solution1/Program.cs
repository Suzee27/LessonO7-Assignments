using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            // lexicographical order
            char[] arrayA = new char[3] { 'a', 'b', 'c' };
            Char[] arrayB = new char[3] { 'a', 'b', 'c' };
            if (arrayA.Length > arrayB.Length)
            {
                Console.WriteLine("The second array comes first lexicographically");
            }
            else if (arrayA.Length < arrayB.Length)
            {
                Console.WriteLine("The first array comes first lexicographically");
            }
            else
            {
                for (int i = 0; i < arrayB.Length; i++)
                {
                    if (arrayA[i] > arrayB[i])
                    {
                        Console.WriteLine("The second array comes first lexicographically");
                        break;
                    }
                    else if (arrayA[i] < arrayB[i])
                    {
                        Console.WriteLine("The first array comes first lexicographically");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Arrays are lexicograhically equal");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
