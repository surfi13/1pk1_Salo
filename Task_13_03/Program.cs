using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { speed = 55f };
            car.Drive();
            Console.ReadKey();
        }
    }
}
