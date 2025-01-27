using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_05
{

    /*В массиве хранятся данные о выпавших осадках за месяц. Необходимо определить кол-во осадков 
    за каждую декаду месяца, вывести день с самыми сильными осадками и вывести отдельно дни без осадков.
    Диопозон осадков от 0 до 300 мм*/

    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int summ1 = 0;
            int summ2 = 0;
            int summ3 = 0;

            int[] mas = new int[30];

            for(int i = 0; i < 30; i++)
            {
                mas[i] = rnd.Next(0, 301);

                if (mas[i] == 0)
                    Console.WriteLine(i + " числа осадков не было");
            }

            for(int d1 = 1; d1 < 10; d1 ++)
            {
                summ1 += mas[d1];
            }
            Console.WriteLine("Первая декада равна " + summ1);

            for (int d2 = 10; d2 < 20; d2++)
            {
                summ2 += mas[d2];
            }
            Console.WriteLine("Вторая декада равна " + summ2);

            for (int d3 = 20; d3 < 30; d3++)
            {
                summ3 += mas[d3];
            }
            Console.WriteLine("Третья декада равна " + summ3);

            Array.Sort(mas);
            int max = mas[29];
            Console.WriteLine("Максимальное количество осадков за день равно " + max);

            Console.ReadKey();
        }
    }
}
