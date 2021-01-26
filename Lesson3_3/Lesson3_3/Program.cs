using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).
                        
            string revmsg = "programming";
            for(int i = revmsg.Length - 1; i >= 0; i--)
            {
                Console.Write(revmsg[i]);
            }

            Console.ReadKey();
        }
    }
}
