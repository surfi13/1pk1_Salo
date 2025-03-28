using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_20_04
{
    /*создайте прорпииу для учета транспортных средств
     храните мписок
    добавте метод постета
    реализульте поиск и вывод инормации*/
    class Program
    {
        static void Main(string[] args)
        {
            List<VehicleType> vehicles = new List<VehicleType>();
            string str;
            do
            {
                Console.WriteLine("Введите номер транспорта");
                str = Console.ReadLine();
                VehicleType vehicleType;
                switch (str)
                {
                    case "1": vehicleType = VehicleType.Car; vehicles.Add(vehicleType); 
                        Console.WriteLine(vehicleType + " добавлен в список"); break;
                    case "2": vehicleType = VehicleType.Bike; vehicles.Add(vehicleType);
                        Console.WriteLine(vehicleType + " добавлен в список"); break;
                    case "3": vehicleType = VehicleType.Bus; vehicles.Add(vehicleType);
                        Console.WriteLine(vehicleType + " добавлен в список"); break;
                    case "4": vehicleType = VehicleType.Truck; vehicles.Add(vehicleType);
                        Console.WriteLine(vehicleType + " добавлен в список"); break;
                    case "5": vehicleType = VehicleType.Motorcycle; vehicles.Add(vehicleType);
                        Console.WriteLine(vehicleType + " добавлен в список"); break;
                    default: Console.WriteLine("Введены некорретные данные"); break;
                }
            }
            while (str != "");
            Console.WriteLine("Список ТС");
            Getinfo(vehicles);
            Console.WriteLine("введите номер транспорта колво еоторого хотите узнать");
            str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Console.WriteLine(Count(vehicles, VehicleType.Car)); break;
                case "2":
                    Console.WriteLine(Count(vehicles, VehicleType.Bike)); break;
                case "3":
                    Console.WriteLine(Count(vehicles, VehicleType.Bus)); break;
                case "4":
                    Console.WriteLine(Count(vehicles, VehicleType.Truck)); break;
                case "5":
                    Console.WriteLine(Count(vehicles, VehicleType.Motorcycle)); break;
                default: Console.WriteLine("Введены некорретные данные"); break;
            }
            Console.ReadKey();
        }
        public static int Count(List<VehicleType> vehicles, VehicleType type)
        {
            int count = 0;
            foreach (var vehicle in vehicles)
            {
             if(vehicle==type)
                count++;
            }
            return count;
        }
        public static void Getinfo(List<VehicleType> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

    }
}
