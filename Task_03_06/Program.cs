using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_06
{

    /*Написать программу которая выводит значение функции с шагом 0.5*/

    class Program
    {
        static void Main(string[] args)
        {

            double y;
            Console.WriteLine("Х равно  У равно");
            for(double x = -4;x <= 4; x += 0.5)
            {
                y = Math.Abs(x);
                Console.WriteLine(x + "       " + y);
            }
            Console.ReadKey();
        }
    }
}
