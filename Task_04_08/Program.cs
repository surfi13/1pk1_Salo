using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_08
{

    /*Дан массив из 50 элементов. Найти кол-во пар элементов равны*/

    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            int[] mas = new int[50];
            int j = 0;

            for (int i = 1; i < 50; i++)
            {
                mas[i] = rdn.Next(0, 10);

                if (mas[i] == mas[i - 1])
                    j++;
            }

            Console.WriteLine("Количество пар одинановых чисел равно " + j);
            Console.ReadKey();
        }
    }
}
