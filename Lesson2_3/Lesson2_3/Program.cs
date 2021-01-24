using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определить, является ли введённое пользователем число чётным.

            Console.WriteLine("Четное или нечетное? Введите число: ");
            var num = Convert.ToDouble(Console.ReadLine());

            var result = num % 2;
            if(result == 0)
            {
                Console.WriteLine("Число четное!");
            }
            else
            {
                Console.WriteLine("Число нечетное!");
            }

            Console.ReadKey();
        }
    }
}
