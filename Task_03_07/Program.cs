using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_07
{

    /*Написать программу которая выводит таблицу скорости каждые 0.5 секунд свободно падающего тела*/

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите начальную скорость тела");
            double v0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время сколько падало тело");
            double t = Convert.ToDouble(Console.ReadLine());
            double v;
            Console.WriteLine("Скорость     Время");

            for (double i = 0; i <= t; i += 0.5)
            {
                v = v0 + 9.8 * i;
                Console.WriteLine(v + "        " + i);
            }
            Console.ReadLine();
        }
    }
}
