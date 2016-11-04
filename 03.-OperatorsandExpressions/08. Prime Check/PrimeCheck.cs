using System;


class PrimeCheck
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N > 1 && N % N == 0 && N % 1 == 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
