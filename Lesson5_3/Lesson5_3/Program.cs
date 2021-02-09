using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.	Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
            byte[] byteFile = {1, 3, 5, 7, 9};
            File.WriteAllBytes("bytes.bin", byteFile);
        }
    }
}
