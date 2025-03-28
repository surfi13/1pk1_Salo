using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку");
            string strosnova = Console.ReadLine();
            Console.WriteLine("Введите строку для поика");
            string strpoisk = Console.ReadLine();
            if (strosnova.Contains(strpoisk))
            {
                Console.WriteLine("Введите слово на которое будет заменено");
                string strzamen = Console.ReadLine();
                string strnew = strosnova.Replace(strpoisk, strzamen);
                Console.WriteLine(strnew);
            }
            else
                Console.WriteLine("Строка не найдена");
            Console.ReadKey();
        }
    }
}
