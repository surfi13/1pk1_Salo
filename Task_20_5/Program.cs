using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите уровень своего доступа");
            string str = Console.ReadLine();
            AccessLevel accessLevel;
            switch (str)
            {
                case "1":
                    accessLevel = AccessLevel.Guest; Proverka(accessLevel); break;
                case "2":
                    accessLevel = AccessLevel.User; Proverka(accessLevel); break;
                case "3":
                    accessLevel = AccessLevel.Moderator; Proverka(accessLevel); break;
                case "4":
                    accessLevel = AccessLevel.Admin; Proverka(accessLevel); break;
                default: Console.WriteLine("Введены некорретные данные"); break;
            }
            Console.ReadKey();
        }
        public static void Proverka(AccessLevel level)
        {
            if (level == AccessLevel.Admin)
            {
                string str = Console.ReadLine();
                if (str == "Delete")
                    Console.WriteLine("Коментарий удален");
                else if (str == "Write")
                    str = Console.ReadLine();
                else
                    Console.WriteLine("Comment");
            }
            if (level == AccessLevel.Moderator)
            {
                string str = Console.ReadLine();
                if (str == "Delete")
                    Console.WriteLine("Коментарий удален");
                else if (str == "Write")
                    Console.WriteLine("Недоствточно прав");
                else
                    Console.WriteLine("Недоствточно прав");
            }
            if (level == AccessLevel.User)
            {
                string str = Console.ReadLine();
                if (str == "Delete")
                    Console.WriteLine("Недоствточно прав");
                else if (str == "Write")
                    str = Console.ReadLine();
                else
                    Console.WriteLine("Comment");
            }
            if (level == AccessLevel.Guest)
            {
                string str = Console.ReadLine();
                if (str == "Delete")
                    Console.WriteLine("Недоствточно прав");
                else if (str == "Write")
                    Console.WriteLine("Недоствточно прав");
                else
                    Console.WriteLine("Comment");
            }
        }

    }
}
