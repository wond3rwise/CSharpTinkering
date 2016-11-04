using System;



class MoonGravity
{
    static void Main()
    {
        decimal W = decimal.Parse(Console.ReadLine());
        decimal mW = W * 0.17M;
        Console.WriteLine("{0:0.000}", mW);

    }
}

