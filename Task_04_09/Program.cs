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

            for (int i = 0; i < 50; i++)
            {
                mas[i] = rdn.Next(0, 30);
            }
            
            for(int j = 0; j < 50; j++)
            {
                bool dup = false;
                for (int k = 0; k < 50; k++)
                {
                    if (mas[j] == mas[k])
                    {
                        dup = true;
                        break;
                    }
                if(!dup)
                    Console.WriteLine(mas[j]);
                }
            }
            Console.ReadKey();
        }
    }
}
