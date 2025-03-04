using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat_Dog dog = new Cat_Dog();
            dog.animal = "Собака";
            dog.name = "Дружок";
            dog.years = 6;
            dog.Info();

            Cat_Dog cat = new Cat_Dog();
            cat.animal = "Кошка";
            cat.name = "Белка";
            cat.years = 12;
            cat.Info();

            Console.ReadKey();
        }
    }
}
