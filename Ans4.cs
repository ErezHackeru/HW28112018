using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many classes ?");
            int numOfClass = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("How many students ?");
            int numOfStudents = Convert.ToInt16(Console.ReadLine());

            int[][] school = new int[numOfClass][];
            int[] all_nums = new int[numOfStudents];
            //initializing the jagged array:
            for (int i = 0; i < numOfClass; i++)
            {                   
                school[i] = new int[numOfStudents] ;                
            }
            //insert data to the jagged array from the user:
            int[] tmpArr = new int[numOfStudents];
            for (int i = 0; i < numOfClass; i++)
            {
                for (int j = 0; j < tmpArr.Length; j++)
                {
                    Console.WriteLine("write a grade");
                    tmpArr[j] = Convert.ToInt16(Console.ReadLine());
                }
                Array.Copy(tmpArr, school[i], numOfStudents);
            }
            //calc avg and print the max value:
            int sum = 0;
            int[] avg = new int[numOfClass];
            for (int i = 0; i < numOfClass; i++)
            {
                all_nums = school[i];
                for (int j = 0; j < all_nums.Length; j++)
                {
                    sum += all_nums[j];
                }
                avg[i] = sum / numOfStudents;
                sum = 0;
            }

            Console.WriteLine("Biggest avg is: " + avg.Max() + " in class: " + avg.ToList().IndexOf(avg.Max()));
            

            Console.ReadLine();
        }
    }
}
