using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_04
{

    //Пользователь вводит своё д/р произвести расчет является ли пользователь соввершеннолетним на текущаю дату и вывести сообщение об этом 

    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введите год своего рождения");
         int year1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Вы месяц своего рождения");
         int month1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите день своего рождения");
         int day1 = Convert.ToInt32(Console.ReadLine());

         int year2 = 2025;
         int month2 = 1;
         int day2 = 17;

         int year = year2 - year1;
        if(year <= 18)
            {
             int month = month2 - month1;
             if (month == 0) 
                {
                    int day = day2 - day1;
                    if (day <= 0)
                        Console.WriteLine("Вы несовершеннолетний");
                    else
                        Console.WriteLine("Вы совершеннолетний");
                }
             else
                    Console.WriteLine("Вы несовершеннолетний");
            }
        else
                Console.WriteLine("Вы совершеннолетний");

        Console.ReadKey();
        }
    }
}
