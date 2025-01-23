using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_05
{

    /*Написать програму котороя выводит на экран таблицу соответствия температуры
     в градусах Цельсия и Фаренгейта. Диапозон изменения изменения температуры в Цельсиях и
    шаг вводятся пользователем*/

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число от которого будет создана таблица");
            double dio1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число до которого будет создана таблица");
            double dio2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг таблицы");
            double shag = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Цельсия   Фаренгейта");

            double j;

            for(double i = dio1; i < dio2; i += shag) {
                j = i * 1.8 + 32;
                Console.WriteLine(i + "         " + j);
            }
            Console.ReadKey();
        }
    }
}
