using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_06
{

    /*Заполните массив случайными положительными и отрицательными числами так чтобы вс числа были по 
     модулю разные и найдите срелт них польшее по модулю*/

    class Program
    {
        static void Main(string[] args)
        {

            Random rdn = new Random();
            int[] mas = new int[110];

            for(int i = 0; i < mas.Length; i++)
            {
                mas[i] = rdn.Next(-1000, -1);
            }
            mas.Distinct();

            for (int k = 0; k < mas.Length; k++)
            {
                mas[k] = rdn.Next(1, 3) == 1 ? Math.Abs(mas[k]) : mas[k];
            }

            for (int j = 0; j < mas.Length; j++)
            {
                mas[j] = Math.Abs(mas[j]);
            }

            Array.Sort(mas);
            int max = mas[109];
            Console.WriteLine("Наибольшее число по модулю " + max);

            Console.ReadKey();
        }
    }
}
