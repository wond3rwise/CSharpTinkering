using System;

class DecimalToBinary
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string output = "";

        do
        {
            output = (input % 2 == 0 ? "0" : "1") + output;
            input /= 2;
        } while (input != 0);

        Console.WriteLine(output);
    }
}