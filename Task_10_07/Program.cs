using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_07
{
    /*Cоздайте метод с помощью которого можно сгенерировать и вернуть символьный двухмерный
    массив(состоящий из символов русского алфавита) и выведите данный массив с помощью
    другого метода(который принимает данные массива в качестве параметра*/
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array = Mass(2, 2);
            PrintArray(array);
            Console.ReadKey();
        }

        public static char Mass(int a, int b)
        {
            char[,] mass = new char[a, b];
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mass[i, j] = (char)rnd.Next('А', 'Я');
                }
            }

            return mass[a,b];
        }

        public static void PrintArray(char[,] mass)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
