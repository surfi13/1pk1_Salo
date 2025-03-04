using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_06
{
    /*Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n, 
     выводит на консоль сгенерированный массив размерностью n*n*/

    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите размерность массива");
                int N = Convert.ToInt32(Console.ReadLine());
                ArrayGeneration(N);
                Console.ReadKey();
            }
            public static void ArrayGeneration(int n)
            {
                int[,] mass = new int[n, n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mass[i, j] = rnd.Next(1, 100);
                        Console.Write(mass[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
    }
}
