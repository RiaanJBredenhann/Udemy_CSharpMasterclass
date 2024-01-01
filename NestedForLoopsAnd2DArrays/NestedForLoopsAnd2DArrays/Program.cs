using System.Numerics;

namespace NestedForLoopsAnd2DArrays
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        static void Main(string[] args)
        {

            Console.WriteLine("foreach loop");
            foreach (int num in matrix)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("");


            Console.WriteLine("nested for loop");
            // loops through rows
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // loops through columns
                for (int j = 0; j < matrix.GetLength(1) ;j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");


            Console.WriteLine("nested for loop only odd");
            // loops through rows
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // loops through columns
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");


            Console.WriteLine("nested for loop only even");
            // loops through rows
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // loops through columns
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");


            Console.WriteLine("nested for loop only diagonal left to right");
            // loops through rows
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // loops through columns
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }


            Console.WriteLine("nested for loop only diagonal right to left");
            // loops through rows
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // loops through columns
                for (int j = matrix.GetLength(1); j >= 0 ; j--)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i,i] + " ");
            }

            for (int i = 0, j = matrix.GetLength(1); i < matrix.GetLength(0); i++, j--)
            {
                Console.Write(matrix[i,j] + " ");
            }
        }
    }
}
