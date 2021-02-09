using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.

            string path = @"C:/ExampleDir/";
            string [] catTree = Directory.GetFileSystemEntries(path, "*.*", SearchOption.AllDirectories);
            for(int i = 0; i < catTree.Length; i++)
            {
                File.WriteAllLines(@"C:/ExampleDir/Dirinfo.txt", catTree);                
            }
        }
    }
}
