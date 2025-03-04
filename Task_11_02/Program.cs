using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_02
{
    /*Передача по ссылке Напишите метод который принримает два целых числа и меняет их местами*/
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Lakir(ref a, ref b);
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }

        public static void Lakir(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a + " " + b);
        }
    }
}
