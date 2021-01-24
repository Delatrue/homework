using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Привет, {Environment.UserName}, сегодня {DateTime.Now.ToLongDateString ()}");
            string usrname = Environment.UserName;
            Console.ReadKey();
        }
    }
}
