using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace Lesson07Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3x3 matrix
            double[,] matrixA = new double[3, 3];
            double[,] matrixB = new double[3, 3];

            for (int row = 0; row < matrixA.GetLength(0); row++)
            {
                for (int col = 0; col < matrixA.GetLength(1); col++)
                {
                    Console.Write("Enter Matrix A[{0}, {1}] = ", row, col);
                    matrixA[row, col] = double.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < matrixB.GetLength(0); row++)
            {
                for (int col = 0; col < matrixB.GetLength(1); col++)
                {
                    Console.Write("Enter Matrix B[{0}, {1}] = ", row, col);
                    matrixB[row, col] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix A");
            for (int row = 0; row < matrixA.GetLength(0); row++)
            {
                for (int col = 0; col < matrixA.GetLength(1); col++)
                {
                      Console.WriteLine("Element {0}, {1} = {2}", row, col, matrixA[row, col]);
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(" Matrix B");
            for (int row = 0; row < matrixB.GetLength(0); row++)
            {
                for (int col = 0; col < matrixB.GetLength(1); col++)
                {
                    Console.WriteLine("Element {0}, {1} = {2}", row, col, matrixB[row, col]);
                }
            }
            double[,] matrixC = new double[3, 3];

            Console.WriteLine("Select a matrix operation to perform");
            Console.WriteLine("A. addition.  B. subraction.   C. multiplication");
            string option = Console.ReadLine();

            if (option == "a" && option == "A")
            {
                // addition
                for (int row = 0; row < matrixA.GetLength(0); row++)
                {
                    for (int col = 0; col < matrixB.GetLength(1); col++)
                    {
                        matrixC[row, col] = matrixA[row, col] + matrixB[row, col];
                        Console.WriteLine("Element {0}, {1} = {2}", row, col, matrixC[row, col]);
                    }
                }
            }

            else if (option == "b" && option == "B")
            {
                // subtraction
                for (int row = 0; row < matrixA.GetLength(0); row++)
                {
                    for (int col = 0; col < matrixB.GetLength(1); col++)
                    {
                        matrixC[row, col] = matrixA[row, col] - matrixB[row, col];
                        Console.WriteLine("Element {0}, {1} = {2}", row, col, matrixC[row, col]);
                    }
                }
            }
            else
            {
                //// multiplication
                //System.Windows.Media.Matrix();
                //    Multiply
                //    (System.Windows.Media,Matrix)
            }
       
            
            
            Console.ReadKey();
        }
      
        void FourDArray()
        {
            // 4 dimensional array (2 x 3 x 5 x 4)
            int[,,,] my4DArray = new int[2, 3, 4, 5]
            {
                { { { 1, 1, 1, 1, 1 },
                {2, 2, 2, 2, 2 },
                {3, 3, 3, 3, 3 },
                {4, 4, 4, 4, 4 } },
                {{5, 5, 5, 5, 5 },
                { 6, 6, 6, 6, 6},
                {7, 7, 7, 7, 7 },
                {8, 8, 8, 8, 8 } },
                {{9, 9, 9, 9, 9 },
                {10, 10, 10, 10, 10 },
                {11, 11, 11, 11, 11 },
                {12, 12, 12, 12, 12 } } },
                { {{13, 13, 13, 13, 13 },
                {14, 14, 14, 14, 14 },
                {15, 15, 15, 15, 15 },
                {16, 16, 16, 16, 16 } },
                {{17, 17, 17, 17, 17 },
                {18, 18, 18, 18, 18 },
                {19, 19, 19, 19, 19 },
                {20, 20, 20, 20, 20 } },
                { {21, 21, 21, 21, 21 },
                {22, 22, 22, 22, 22 },
                {23, 23, 23, 23, 23 },
                {24, 24, 24, 24, 24 }} }
                };
        }
    }
}
