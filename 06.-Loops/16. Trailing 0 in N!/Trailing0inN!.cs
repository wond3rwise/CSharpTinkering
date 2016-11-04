using System;

class Trailing0inNFact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int addFactor = 0;
        int devide = 0;
        int counter = 1;

        while (true)
        {
            devide = (int)Math.Pow(5, counter);
            addFactor += n / devide;
            if ((n / devide) < 1)
            {
                break;
            }
            counter++;
        }
        Console.WriteLine(addFactor);
    }
}