using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_09
{

    /*Вклад в бвнке составляет х рублей. Ежегодно он увеличивается на р процентов, после чего 
     дробнвя часть копеек отбрасывется. Каждый год сумма вклада становится больше. Определите, через
    сколько лет не менее у рублей*/

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите начальный вклад");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите прочентеую ставку");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите желаемую сумму");
            double y = Convert.ToDouble(Console.ReadLine());

            int j = 0;
            for (double i = 0; ; i++)
            {
                x = x * ((100 + p) / 100);
                j++;
                if (y <= x)
                    break;
             
            }

            Console.WriteLine("Желаемая сумма накопится через " + j + " лет");
            Console.ReadKey();
        }
    }
}
