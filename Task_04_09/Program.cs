using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_09
{

    //Найти в массиве элементы которые встречвются только один раз

    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            int[] mas = new int[50];
            int n = 0;

            for (int i = 0; i < 50; i++)
            {
                mas[i] = rdn.Next(0, 300);
            }

            for (int i = 0; i < 50; i++)
            {
                for (int j = i +1; j < 50; j++)
                {
                    if (mas[i] == mas[j])
                        n++;
                }
                if (n == 0)
                    Console.Write(mas[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
