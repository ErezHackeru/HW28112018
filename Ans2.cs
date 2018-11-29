using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numMatrix = new int[5, 5];
            Random x = new Random();
            for (int i = 0; i < numMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < numMatrix.GetLength(1); j++)
                {
                    numMatrix[i, j] = x.Next(1, 11);
                }
            }
            //print the matrix:
            for (int i = 0; i < numMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < numMatrix.GetLength(1); j++)
                {
                    Console.Write(numMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("write a number to check:");
            int numToCheck = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < numMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < numMatrix.GetLength(1); j++)
                {
                    if (numMatrix[i, j] == numToCheck)
                        Console.WriteLine("The row is: " + i + " The column is: " + j);
                }
            }

            Console.ReadLine();
        }
    }
}
