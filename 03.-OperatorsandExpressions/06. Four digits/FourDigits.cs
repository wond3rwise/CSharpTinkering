using System;

class FourDigits
{
    static void Main()
    {
        int cifra = int.Parse(Console.ReadLine());
        int a = cifra / 1000;
        int b = (cifra / 100) % 10;
        int c = (cifra / 10) % 10;
        int d = cifra % 10;
        int abcd = a + b + c + d;
        Console.WriteLine("{0}", abcd);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}

