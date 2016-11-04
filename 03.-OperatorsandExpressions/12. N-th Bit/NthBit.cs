using System;


class NthBit
{
    static void Main()
    {
        long P = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        long moveBit = P >> N;
        long foundBit = moveBit & 1;
        Console.WriteLine(foundBit);
    }
}

