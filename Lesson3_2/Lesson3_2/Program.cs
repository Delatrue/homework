using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написать программу «Телефонный справочник»: создать двумерный массив 5х2,
            хранящий список телефонных контактов: первый элемент хранит имя контакта, 
            второй — номер телефона/ email.
            */
            Console.WriteLine("Телефонный справочник");

            string[,] phoneBook = new string[5, 2]
            {
                {"Петров ", "89001112233 / petrov@mail.ru" },
                {"Иванов ", "89002223344 / ivanov@mail.ru" },
                {"Сидоров ", "89003334455 / sidorov@mail.ru"},
                {"Скворцов ", "89004445566 / skvorcov@mail.ru" },
                {"Синицин ", "89005556677 / sinicin@mail.ru" }
            };
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write($"{phoneBook[i, j]}");
                }
            Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
