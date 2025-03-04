using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_01
{
    /*Передача по значению Напишите метод который принримает два целых числа и меняет их местами*/
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Lakir(a, b);
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }

        public static void Lakir(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a + " " + b);
        }
    }
}
