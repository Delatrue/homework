using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            (*) Для полного закрепления битовых масок, попытайтесь создать универсальную 
            структуру расписания недели, к примеру, чтобы описать работу какого либо офиса. 
            Явный пример - офис номер 1 работает со вторника до пятницы, 
            офис номер 2 работает с понедельника до воскресенья.
            */
            {
                int office = 0b0011110;
                
                int monMask = 0b0000001;
                int tueMask = 0b0000010;
                int wenMask = 0b0000100;
                int thuMask = 0b0001000;
                int friMask = 0b0010000;
                int satMask = 0b0100000;
                int sunMask = 0b1000000;

                int workMon = office & monMask;
                int workTue = office & tueMask;
                int workWen = office & wenMask;
                int workThu = office & thuMask;
                int workFri = office & friMask;
                int workSat = office & satMask;
                int workSun = office & sunMask;

                Console.WriteLine("График работы Офиса 1");
                Console.WriteLine("ПН: " + (workMon == monMask));
                Console.WriteLine("ВТ: " + (workTue == tueMask));
                Console.WriteLine("СР: " + (workWen == wenMask));
                Console.WriteLine("ЧТ: " + (workThu == thuMask));
                Console.WriteLine("ПТ: " + (workFri == friMask));
                Console.WriteLine("СБ: " + (workSat == satMask));
                Console.WriteLine("ВС: " + (workSun == sunMask));
                
            }
            {
               
                int office = 0b1111111;

                int monMask = 0b0000001;
                int tueMask = 0b0000010;
                int wenMask = 0b0000100;
                int thuMask = 0b0001000;
                int friMask = 0b0010000;
                int satMask = 0b0100000;
                int sunMask = 0b1000000;

                int workMon = office & monMask;
                int workTue = office & tueMask;
                int workWen = office & wenMask;
                int workThu = office & thuMask;
                int workFri = office & friMask;
                int workSat = office & satMask;
                int workSun = office & sunMask;

                Console.WriteLine("График работы Офиса 2");
                Console.WriteLine("ПН: " + (workMon == monMask));
                Console.WriteLine("ВТ: " + (workTue == tueMask));
                Console.WriteLine("СР: " + (workWen == wenMask));
                Console.WriteLine("ЧТ: " + (workThu == thuMask));
                Console.WriteLine("ПТ: " + (workFri == friMask));
                Console.WriteLine("СБ: " + (workSat == satMask));
                Console.WriteLine("ВС: " + (workSun == sunMask));

                Console.ReadKey();
            }
            






        }
    }
}
