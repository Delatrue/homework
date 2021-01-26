using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, 
                где Х — элементы кораблей, а О — свободные клетки.            
            */

            string[,] seaBattle = new string[10, 10];
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    seaBattle[i, j] = "O ";
                    
                    seaBattle[1, 1] = "X ";     // 4х палубный - 1 шт                    
                    seaBattle[1, 2] = "X ";
                    seaBattle[1, 3] = "X ";
                    seaBattle[1, 4] = "X ";

                    seaBattle[1, 6] = "X ";     // 3х палубный - 2 шт
                    seaBattle[1, 7] = "X ";
                    seaBattle[1, 8] = "X ";
                    seaBattle[3, 1] = "X ";     
                    seaBattle[3, 2] = "X ";
                    seaBattle[3, 3] = "X ";

                    seaBattle[3, 5] = "X ";     // 2х палубный - 3 шт
                    seaBattle[3, 6] = "X ";
                    seaBattle[5, 1] = "X ";
                    seaBattle[5, 2] = "X ";
                    seaBattle[5, 4] = "X ";
                    seaBattle[5, 5] = "X ";

                    seaBattle[5, 7] = "X ";     // 1 палубный - 4 шт
                    seaBattle[7, 1] = "X ";
                    seaBattle[7, 3] = "X ";
                    seaBattle[7, 5] = "X ";

                    Console.Write($"{seaBattle[i, j]}");

                }
                Console.WriteLine();
            
                
            }

            Console.ReadKey();
        }
    }
}
