using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_3
{
    class Program
    {

        enum Season
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            /*
            Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
            На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
            Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года 
            (зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
            Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
            */

            Console.WriteLine("Введите порядковый номер месяца: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());

            string month2 = null;
            YearTime(ref monthNum);
            Program.YearTimeRu(ref month2, ref monthNum);
            

            if (monthNum < 1 || monthNum > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            else
            {
                Console.WriteLine($"Время года - {month2}");
            }



            Console.ReadKey();
        }        
        static void YearTime(ref int monthNum)
        {
            if (monthNum == 1 || monthNum == 12 || monthNum == 2)
            {
                monthNum = (int)Season.Winter;
            }
            else if (monthNum == 3 || monthNum == 4 || monthNum == 5)
            {
                monthNum = (int)Season.Spring;
            }
            else if (monthNum == 6 || monthNum == 7 || monthNum == 8)
            {
                monthNum = (int)Season.Summer;
            }
            else if (monthNum == 9 || monthNum == 10 || monthNum == 11)
            {
                monthNum = (int)Season.Autumn;
            }            
        }
        static void YearTimeRu(ref string month2, ref int monthNum)
        {
            if (monthNum == 1)
            {
                month2 = "зима";
            }
            else if (monthNum == 2)
            {
                month2 = "весна";
            }
            else if (monthNum == 3)
            {
                month2 = "лето";
            }
            else if (monthNum == 4)
            {
                month2 = "осень";
            }
            
        }
    }
}
