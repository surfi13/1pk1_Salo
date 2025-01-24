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
            
        }
    }
}
