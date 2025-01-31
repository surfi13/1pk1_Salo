using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_04
{

    /*Дан квадратный массив. Произведите анализ данной матрицы и выясните являлится ли данная матрица диоганальной
     Если она диоганальная вывести её с выделение цветом главной диагонали иначе 
    сообщение что она не диоганальная*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n =  Convert.ToInt32(Console.ReadLine());

            int[,] mass = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rnd.Next(-100, 101); 
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (mass[i, j] != 0)
                    {
                        if (i == j)
                            continue;

                        Console.WriteLine("Массив не диогональный");
                        
                    }
                }
             }

            for (int k = 0; k < n; k++)
            {
                for (int g = 0; g < n; g++)
                {
                    if (k == g)
                        Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(mass[k, g] + " ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
     }
 }

