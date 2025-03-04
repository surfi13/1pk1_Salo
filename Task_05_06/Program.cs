using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_06
{
    /*Осущевствить генерацию двухмерного массива 10*5 по следующим првлам
     1 столбец содержит нули
    2 столбец содержит числа кратные 2
    3 столбец содержит числа кратные 3
    4 столбец содержит числа кратные 4
    5 столбец содержит числа кратные 5
    Осущевствить переворот массива*/
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[10, 5];
            Random rnd = new Random();

            Console.WriteLine("1 массив");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        mas[i, j] = 0;
                        Console.Write(mas[i, j] + " ");
                    }
                    else if (j == 1)
                    {
                        if ((mas[i, j] = rnd.Next(1, 100)) % 2 == 0)
                            Console.Write(mas[i, j] + " ");
                        else
                        {
                            do
                            {
                                mas[i, j] = rnd.Next(1, 100) % 2;
                            } while ((mas[i, j] = rnd.Next(1, 100)) % 2 != 0);
                            Console.Write(mas[i, j] + " ");
                        }
                    }
                    else if (j == 2)
                    {
                        if ((mas[i, j] = rnd.Next(1, 100)) % 3 == 0)
                            Console.Write(mas[i, j] + " ");
                        else
                        {
                            do
                            {
                                mas[i, j] = rnd.Next(1, 100) % 3;
                            } while ((mas[i, j] = rnd.Next(1, 100)) % 3 != 0);
                            Console.Write(mas[i, j] + " ");
                        }
                    }
                    else if (j == 3)
                    {
                        if ((mas[i, j] = rnd.Next(1, 100)) % 4 == 0)
                            Console.Write(mas[i, j] + " ");
                        else
                        {
                            do
                            {
                                mas[i, j] = rnd.Next(1, 100) % 4;
                            } while ((mas[i, j] = rnd.Next(1, 100)) % 4 != 0);
                            Console.Write(mas[i, j] + " ");
                        }
                    }
                    else
                    {
                        if ((mas[i, j] = rnd.Next(1, 100)) % 5 == 0)
                            Console.Write(mas[i, j] + " ");
                        else
                        {
                            do
                            {
                                mas[i, j] = rnd.Next(1, 100) % 5;
                            } while ((mas[i, j] = rnd.Next(1, 100)) % 5 != 0);
                            Console.Write(mas[i, j] + " ");
                        }
                    }
                }
                Console.WriteLine("");
            }

            Console.WriteLine("2 массив");
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    Console.Write(mas[j, i] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
