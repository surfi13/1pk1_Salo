using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet(35, false);
            pet.Info();
            pet.Height(27);
            pet.Heath(true);
            pet.Info();
            Console.ReadKey();
        }
    }
}
