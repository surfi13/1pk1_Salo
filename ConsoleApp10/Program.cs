using System;

//02 Найти значение выражения при a=14, b=8 c= п/4

class Program
{
    static void Main()
    {
        double a = 14;
        double b = 8;
        double c = Math.PI / 4;

        double p1 = Math.Pow(a - 1, 1/3);
        double p2 = Math.Pow(b + p1, 1/4);
        double p3 = Math.Abs(a -b) * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c));
        double p4 = p2 / p3;

        Console.WriteLine(p4);
        Console.ReadKey();
    }
}