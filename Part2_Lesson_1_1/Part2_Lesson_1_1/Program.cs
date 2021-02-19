using System;
using System.IO;

namespace Part2_Lesson_1_1
{    
    class Program
    {
        /*1.Напишите на C# функцию согласно блок-схеме
            Требуется реализовать на C# функцию согласно блок-схеме. 
            Блок-схема описывает алгоритм проверки, простое число или нет.
            Написать консольное приложение.
            Алгоритм реализовать отдельно в функции согласно блок - схеме.
            Написать проверочный код в main функции.
            Код выложить на GitHub.
            */
        public class TestNum
        {
            public int InputNum { get; set; }
            public int Expected { get; set; }
            //Expected == 1 - простое число
            //Expected == 0 - составное число
        }
        //метод SimpleNum() написан согласно блок-схеме задания. 
        //Данная схема не учитывает исключения чисел таких как 0, 1, 33 и т.д.
        static int SimpleNum(int n)
        {
            int d = 0;
            int i = 2;
            if (i < n)
            {
                if(n % i == 0)
                {
                    return d++;
                }
                else
                {
                    return i++;
                }
            }
            else
            {
                if(d == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {            
            var testCase = new TestNum[4];
            testCase[0] = new TestNum()
            {
                InputNum = 2,
                Expected = 1
            };
            testCase[1] = new TestNum()
            {
                InputNum = -19,
                Expected = 1
            };
            testCase[2] = new TestNum()
            {
                InputNum = 88,
                Expected = 0
            };
            testCase[3] = new TestNum()
            {
                InputNum = 642,
                Expected = 0
            };
            
            foreach(var test in testCase)
            {
                var result = SimpleNum(test.InputNum);
                Console.WriteLine($"на вход {test.InputNum} - получаем {result} (ожидаем {test.Expected})");

            }
            Console.WriteLine(" 1 - простое число, 0 - составное число.");
            

        }
        
    }
}
