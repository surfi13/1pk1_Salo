using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_08
{

    /*Даны натуральные числа от 20 до 50. Напечатать те которые делятся на 3 но не делятся на 5*/
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 20; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
