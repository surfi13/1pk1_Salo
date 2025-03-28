using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_06
{
    /*создайте программу имитирующую светофор
     реализуйте автоматическое переключение
    при смене выводить на консоль
    возможность ручного переключения*/
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLightColor color = TrafficLightColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.WriteLine("Red");
            }
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("Yellow");
            }
            else if (Console.ReadKey().Key == ConsoleKey.G)
            {
                Console.WriteLine("Green");
            }
            Console.ReadKey();
        }
    }
}
