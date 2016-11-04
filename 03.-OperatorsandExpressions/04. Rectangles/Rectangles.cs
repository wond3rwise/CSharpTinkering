using System;

class Rectangles
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal S = a * b;
        decimal P = (a + b) * 2;
        Console.WriteLine("{0:0.00} {1:0.00}", S, P);
    }
}

