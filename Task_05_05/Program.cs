using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_05
{
    /*У пользователя запрашивается числа n и m, генерируется прямоугольный массив. Заполнение случайно в диапозоне
     от -99 до 99 влючительно. осуществить преобразование
    если элемент меньше 0 то знак обрасывается и выеляется зеленым цветом
    если элемент раве 0 то пересаписы вае как единиц и выделяем красным*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размерность массива");
            int m =  Convert.ToInt32(Console.ReadLine());

            int[,] mass = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mass[i, j] = rnd.Next(-99, 100);
                }

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mass[i, j] < 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(Math.Abs(mass[i, j]));
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    else if (mass[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(1);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    else
                        Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
