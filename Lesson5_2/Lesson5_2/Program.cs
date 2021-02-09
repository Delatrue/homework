using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.	Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

            string myFile = "startup.txt";
            File.AppendAllText(myFile, $"{DateTime.Now}\n");
            
        }
    }
}
