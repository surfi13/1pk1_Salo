using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02
{
    public class Cat_Dog
    {
        public string animal;
        public string name;
        public int years;
        public bool heal;
        public bool eat;

        public void Info()
        {
            Console.WriteLine(animal + " по кличке " + name + " прожила " + years +
                " года.");
        }
    }
}
