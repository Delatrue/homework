using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

            string myFile = "Mytxt.txt";
            File.WriteAllText(myFile, "Создание текстового файла через VS");
        }
    }
}
