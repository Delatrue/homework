using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, выводящую элементы двухмерного массива по диагонали.

            int[,] arr2 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{arr2[i, i]} ");
            }
            Console.ReadKey();
                     
        }
    }
}
