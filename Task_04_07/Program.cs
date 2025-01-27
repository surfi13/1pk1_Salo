using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_07
{

    /*В массиве из 30 элементов заданы значения роста ученико при этом рост мальчиво условно отрицательный
    нужно посчитать кол-во девочек и мальчико в классе, ф также среднии значения роста для обоих полов*/

    class Program
    {
        static void Main(string[] args)
        {

            Random rdn = new Random();
            float[] mas = new float[30];
            float man = 0;
            float woman = 0;
            float kolm = 0;
            float kolw = 0;

            for (int i = 0; i < 30; i++)
            {
                mas[i] = rdn.Next(1, 3) == 1 ? rdn.Next(140, 190) : rdn.Next(-200, -140);

                if (mas[i] < 0)
                {
                    man += mas[i];
                    kolm ++;
                }
                else
                {
                    woman += mas[i];
                    kolw++;
                }
            }

            Console.WriteLine("Мальчиков в классе " + kolm);
            Console.WriteLine("Девочек в классе " + kolw);
            Console.WriteLine("Средний рост мальчиков в классе " + Math.Abs(man/kolm) );
            Console.WriteLine("Средний рост девочек в классе " + woman / kolw);

            Console.ReadKey();
        }
    }
}
