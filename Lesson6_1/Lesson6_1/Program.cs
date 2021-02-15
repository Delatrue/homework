using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
             * позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов
             * с помощью указания его ID или имени процесса. В качестве примера можно использовать консольные
             * утилиты Windows tasklist и taskkill.
            */
            foreach (Process process in Process.GetProcesses())
            {                
                Console.WriteLine($"Name: {process.ProcessName} --- ID: {process.Id}  ");
            }
            Console.WriteLine("Выберите способ завершения процесса(1/2):\n1. Ввести имя процесса;\n2. Ввести id процесса;");
            int choose = Convert.ToInt32(Console.ReadLine());
            if(choose == 1)
            {
                KillByName();
            }
            else if(choose == 2)
            {
                KillById();
            }
            else
            {
                Console.WriteLine("Введите 1 или 2");
            }
            Console.ReadKey();
        }
        static void KillByName()
        {
            Console.Write("Введите имя процесса для завершения: ");
            string procName = Console.ReadLine();
            try
            {
                Process proc = Process.GetProcessesByName($"{procName}")[0];
                proc.Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
        }
        static void KillById()
        {
            Console.Write("Введите id процесса для завершения: ");
            int procId = Convert.ToInt32(Console.ReadLine());
            try
            {
                Process proc1 = Process.GetProcessById(procId);
                proc1.Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
