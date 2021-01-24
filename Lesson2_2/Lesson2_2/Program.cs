using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запросить у пользователя порядковый номер текущего месяца и вывести его название.
           
            Console.WriteLine("Введите порядковый номер текущего месяца: ");
            var monthOfYear = Convert.ToByte(Console.ReadLine());
            monthOfYear--;

            string monthTitle = "";
            switch (monthOfYear)
            {
                case 0:
                    monthTitle = "Январь";
                    break;
                case 1:
                    monthTitle = "Февраль";
                    break;
                case 2:
                    monthTitle = "Март";
                    break;
                case 3:
                    monthTitle = "Апрель";
                    break;
                case 4:
                    monthTitle = "Май";
                    break;
                case 5:
                    monthTitle = "Июнь";
                    break;
                case 6:
                    monthTitle = "Июль";
                    break;
                case 7:
                    monthTitle = "Август";
                    break;
                case 8:
                    monthTitle = "Сентябрь";
                    break;
                case 9:
                    monthTitle = "Октябрь";
                    break;
                case 10:
                    monthTitle = "Ноябрь";
                    break;
                case 11:
                    monthTitle = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Введите число от 1 до 12");
                    break;                    
            }
            Console.WriteLine("Текущий месяц - " + monthTitle);
            Console.ReadKey();
        }
    }
}
