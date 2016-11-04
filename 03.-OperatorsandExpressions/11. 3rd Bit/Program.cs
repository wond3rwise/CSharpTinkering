using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(((input >> 3) & 1) == 0 ? "0" : "1");
    }
}
