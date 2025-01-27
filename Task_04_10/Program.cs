using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_10
{

    /*Заполнить массив из 10 элементов числами в диапозоне от -10 до 10 и сделать ревёрс 
     отдульно для ккаждой из двух половин*/

    class Program
    {
        static void Main(string[] args)
        {

           Random rdn = new Random();
            int[] mas = new int[10];
            int[] mas1 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                mas[i] = rdn.Next(-10, 11);
                Console.Write(mas[i] + " ");
            }

            for (int j = 0; j < 5; j++)
            {
                mas1[j] = mas[4 - j];
            }

            for (int j = 0; j < 5; j++)
            {
                mas1[5 + j] = mas[9 - j];
            }

            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {

                Console.Write(mas1[i] + " ");
            }



            Console.ReadKey();
        }
    }
}
