using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написать программу, принимающую на вход строку — набор чисел, 
            разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
            Ввести данные с клавиатуры и вывести результат на экран.
            */
            
            Console.WriteLine("Введите числа через пробел: ");
            string numbers = Console.ReadLine();
            
            char[] separator = new char[] { ' ' };
            string[] numbersWOspace = numbers.Split(separator);

            int sum = 0;
            for (int i = 0; i < numbersWOspace.Length; i++)
            {
                int elem = Convert.ToInt32(numbersWOspace[i]);
                sum += elem;
            }
            Console.WriteLine($"Сумма чисел равна {sum}");
            Console.ReadKey();




        }
    }
}
