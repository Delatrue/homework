using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написать метод GetFullName(string firstName, string lastName, string patronymic), 
            принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
            Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
            */
            int i = 0;
            do
            {
                string fullName = GetFullName();
                Console.WriteLine($"{fullName}\nва");
                i++;
            }
            while (i < 4);
            Console.ReadKey();


        }
        static string GetFullName()
        {
            
            Console.Write("Введите Фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите Имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string patronymic = Console.ReadLine();
            return ($"{lastName} " + $"{firstName} "  + $"{patronymic} " );
            
            

        }
    }
}
