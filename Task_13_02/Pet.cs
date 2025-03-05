using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    class Pet
    {
        public string name;
        public string animal;
        public int height;
        public int years;
        public bool heath;

        public void Info()
        {
            Console.WriteLine("Имя питомца " + name);
            Console.WriteLine("Вид питомца" + animal);
            Console.WriteLine("Вес питомца" + height);
            Console.WriteLine("Возраст питомца" + years);
            Console.WriteLine("Здоров: " + heath);
        }
        public void Heath(bool hp)
        {
            heath = hp;
        }
        public void Height(int hg)
        {
            height = hg;
        }
        
        public Pet() { }
        public Pet(string na, string amal, int heig, int year, bool heth)
        {
            name = na;
            animal = amal;
            height = heig;
            years = year;
            heath = heth;
        }
        public Pet(string na, int heig, int year, bool heth)
        {
            name = na;
            height = heig;
            years = year;
            heath = heth;
        }
        public Pet(string amal, int year, bool heth)
        {
            animal = amal;
            years = year;
            heath = heth;
        }
        public Pet(string na, string amal, int heig, int year)
        {
            name = na;
            animal = amal;
            height = heig;
            years = year;
        }
        public Pet(int heig, bool heth)
        {
            height = heig;
            heath = heth;
        }
    }
}
