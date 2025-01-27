using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_03
{

    /*Даны два массива заполненные симвовами англискрго алфавита 3*3. Проверить являются ли матрицы равными,
     если да, то вывести сообщение о том, что они равны, если нет вывести матрицы повторно с цветовой
    индикацией только равных элементов*/

    class Program
    {
        static void Main(string[] args)
        {

            char[,] mass1 = new char [3, 3];
            char[,] mass2 = new char[3, 3];
            Random rnd = new Random();
            int N = 0;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    mass1[i, j] = (char)rnd.Next('a', 'z');
                }
                
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mass2[i, j] = (char)rnd.Next('a', 'z');
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mass1[i, j] == mass2[i, j])
                        N++;
                }
            }

            if(N == 9)
                Console.WriteLine("Матрицы равны");
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (mass1[i, j] == mass2[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(mass1[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(mass1[i, j] + " ");
                        }
                    }
                    Console.WriteLine(" ");
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(" ");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (mass1[i, j] == mass2[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(mass2[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(mass2[i, j] + " ");
                        }
                    }
                    Console.WriteLine(" ");
                }
            }

            Console.ReadKey();
        }
    }
}
