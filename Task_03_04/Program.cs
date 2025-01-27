using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_04
{

    /*Пользователь вводит с консоли произвольный текст. После каждого ввода консоль очищается. Когда 
    пользователь вводит слово "ext" или пустую строку-ввод останавливается и выводится кол-во срок введённым им*/

    class Program
    {
        static void Main(string[] args)
        {
            string srt;
            int i = 0;

            while (true) {
                Console.WriteLine("Введите любой текст");
                srt = Console.ReadLine();
                Console.Clear();
                if (srt == "ext" || srt == "")
                    break;
                i++;
            }
            Console.WriteLine("Вы ввели " + i + " строк");
            Console.ReadKey();


        }
    }
}
