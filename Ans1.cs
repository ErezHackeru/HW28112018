using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students are in class?");
            int StudentAmount = Convert.ToInt16(Console.ReadLine());
            int[] array = new int[StudentAmount];

            for (int i = 0; i < StudentAmount; i++)
            {
                Console.WriteLine("what is the grade?");
                array[i] = Convert.ToInt16(Console.ReadLine());
            }

            int sum = 0, avg = 0;
            for (int i = 0; i < StudentAmount; i++)
            {
                sum += array[i];
            }
            avg = sum / StudentAmount;
            Console.WriteLine("sum is: " + sum + " avg is: " +avg);

            Console.ReadLine();
        }
    }
}
