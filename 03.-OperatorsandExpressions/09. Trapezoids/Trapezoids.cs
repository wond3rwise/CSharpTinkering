using System;


class Trapezoids
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double S = ((a + b) * 0.5) * h;
        Console.WriteLine("{0:f7}", S);
    }
}

