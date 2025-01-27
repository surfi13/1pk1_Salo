using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_08
{
    /*Даны два массива 10*10 заполненных числами от 1 до 9 включительно
     создай массив который будет произведением двух предыидущих
    вывести полученый массив*/
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass1 = new int[10, 10];
            int[,] mass2 = new int[10, 10];
            int[,] mass3 = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass1[i, j] = rnd.Next(1, 10);
                }

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass2[i, j] = rnd.Next(1, 10);
                }

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass3[i, j] = mass1[i, j] * mass2[i, j];
                    Console.Write(mass3[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
