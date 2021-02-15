using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать консольное приложение, которое при старте выводит приветствие, 
             *записанное в настройках приложения (application-scope). Запросить у пользователя имя, 
             *возраст и род деятельности, а затем сохранить данные в настройках. 
             *При следующем запуске отобразить эти сведения. Задать приложению версию и описание.
            */
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine(greeting);
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.Write("Введите имя пользователя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserAge))
            {
                Console.Write("Введите возраст пользователя: ");
                Properties.Settings.Default.UserAge = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserOccupation))
            {
                Console.Write("Введите род деятельности пользователя: ");
                Properties.Settings.Default.UserOccupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;
            string userAge = Properties.Settings.Default.UserAge;
            string userOccupation = Properties.Settings.Default.UserOccupation;
            Console.WriteLine($"{userName} {userAge} {userOccupation}");

            Console.ReadKey();



        }
    }
}
