using System;

namespace Part2_Lesson_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислите асимптотическую сложность функции из примера ниже. 
            //Ответ: алгоритмическая сложноть = O(2N^3) = O(N^3)
        }

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; // 1
            for (int i = 0; i < inputArray.Length; i++) // N
            {
                for (int j = 0; j < inputArray.Length; j++) // N
                {
                    for (int k = 0; k < inputArray.Length; k++) // N
                    {
                        int y = 0; 

                        if (j != 0) 
                        {
                            y = k / j; 
                        }

                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }

            return sum; // 1
        }

    }
}
