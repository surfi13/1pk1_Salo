using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { ' ', '\n', '\t' });
            string[] predls = text.Split(new char[] { '.', '!', '?' });
            Console.WriteLine("Текст по словам");
            foreach (string word in words) { Console.WriteLine(word); }
            Console.WriteLine("Текст по предложениям");
            foreach (string predl in predls) { Console.WriteLine(predl); }

            Console.ReadKey();

        }
    }
}
