using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_4
{
    class Program
    {
        static int GetNumFibo(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return GetNumFibo(n - 1) + GetNumFibo(n - 2);
            }
        }                
        static void Main(string[] args)
        {
            //(*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.

            Console.Write("Введите порядковый номер Фибоначчи, чтобы узнать его значение: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int res = GetNumFibo(input);

            Console.WriteLine($"{input} число Фибоначчи имеет значение {res}" );
            Console.ReadKey();
            
            
             
            
            

                
            

        }
    }
}
