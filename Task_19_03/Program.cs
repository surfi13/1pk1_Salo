using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19_03
{
    /*Напишите программму в котором осущевстляется по строчный ввод
     ввод завершается после ввода пустой строки. После чего вывемти 
    их все используля разделитель*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            string strn = "";
            while (str != "")
            {
               strn += str;
               str = Console.ReadLine();
               strn += "-";
            }
            int i = strn.LastIndexOf("-");
            Console.WriteLine(strn.Substring(0, i - 1));
            Console.ReadKey();
        }
    }
}
