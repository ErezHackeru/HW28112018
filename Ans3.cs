using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] submarin = new int[3, 3];
            Random x = new Random();
            for (int i = 0; i < submarin.GetLength(0); i++)
            {
                for (int j = 0; j < submarin.GetLength(1); j++)
                {
                    submarin[i, j] = x.Next(0,2);
                }
            }

            //print the matrix:
            int sumOfOnes = 0;
            for (int i = 0; i < submarin.GetLength(0); i++)
            {
                for (int j = 0; j < submarin.GetLength(1); j++)
                {
                    Console.Write(submarin[i, j] + " ");
                    if (submarin[i, j] == 1)
                        sumOfOnes += 1;
                }
                Console.WriteLine();
            }


            Console.WriteLine("Starting the game: ");
            
            int numOfTries = 0;
            while (sumOfOnes != 0)
            {
                Console.WriteLine("Write row: ");
                int rowNum = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Write column: ");
                int columnNum = Convert.ToInt16(Console.ReadLine());

                if (submarin[rowNum, columnNum] == 0)
                    Console.WriteLine("Miss");
                else
                {
                    Console.WriteLine("Boom");
                    submarin[rowNum, columnNum] = 0;
                    sumOfOnes--;
                }
                Console.WriteLine();
                numOfTries++;
            }
            Console.WriteLine("Game is over!");
            Console.WriteLine("Number of tries: " + numOfTries);
            Console.WriteLine();
          
            Console.ReadLine();
        }
    }
}
