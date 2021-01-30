using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            
            Console.WriteLine("Вычисление среднесуточной температуры \nВведите минимальную температуру за сутки: ");
            var TempMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за сутки: ");
            var TempMax = Convert.ToInt32(Console.ReadLine());
            var TempAverage = (TempMin + TempMax) / 2;

            Console.WriteLine("Среднесуточная температура за сутки равна " + TempAverage);
            Console.ReadKey();
        }
    }
}
