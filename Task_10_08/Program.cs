using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_08
{ 
    /*Создайте метод который на вход принимает одномерный массив и число для поиска,
     верните индекс искомого элемента в массиве. Если элемента нет - верните индекс = -1*/
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                mass[i] = rnd.Next(1, 100);
                Console.Write(mass[i] + " ");
            }
            ArrayPoisk(mass, N);
            Console.ReadKey();
        }

        public static void ArrayPoisk(int[] mas, int n)
        {
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                if (mas[i] == n)
                {
                    Console.WriteLine("\n" + i);
                    j++;
                    break;
                }
            }
            if (j == 0)
                Console.WriteLine("\n-1");
        }
    }
}
