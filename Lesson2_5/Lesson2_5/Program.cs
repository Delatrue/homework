using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5
{
    class Program
    {        
        static void Main(string[] args)
        {
            // (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».

            Console.WriteLine("Введите порядковый номер зимнего месяца (12, 1, 2): ");
            var month = Convert.ToInt32(Console.ReadLine());

            string monthName = "";
            switch (month)
            {
                case 0:
                    monthName = "Январь";
                    break;
                case 1:
                    monthName = "Февраль";
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    monthName = "Декабрь";
                    break;

            }

            Console.WriteLine("Введите минимальную температуру за " + monthName + ":");
            var TempMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за " + monthName + ":");
            var TempMax = Convert.ToInt32(Console.ReadLine());
            var TempAverage = (TempMin + TempMax) / 2;

            if (TempAverage > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
            else if (TempAverage < -20)
            {
                Console.WriteLine("Морозная зима");
            }
            else
            {
                Console.WriteLine("Обычная зима");
            }

            Console.ReadKey();
        }
    }
}
