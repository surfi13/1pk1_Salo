using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03
{
    class Car
    {
        public string number;
        public string marka;
        public string color;
        public float speed;

        public void Drive()
        {
            if (speed < 230)
            {
                for (int i = 1; i < 461; i++)
                {
                    speed ++;
                    if (speed >= 230)
                    {
                        for (int j = 1; j < 231;j++)
                        {
                            speed --;
                            if (speed <= 0)
                            {
                                Console.WriteLine("Машина остановилась");
                                break;
                            }
                            Console.WriteLine(speed);
                        }    
                    }
                    Console.WriteLine(speed);
                }
            }
        }

        public Car(string num, string mar, string col, float sp)
        {
            number = num;
            marka = mar;
            color = col;
            speed = sp;
        }
        public Car(string num, string mar, float sp)
        {
            number = num;
            marka = mar;
            speed = sp;
        }
        public Car(float sp)
        {
            speed = sp;
        }
        public Car(string mar, float sp)
        {
            marka = mar;
            speed = sp;
        }
        public Car() { }
    }
}
