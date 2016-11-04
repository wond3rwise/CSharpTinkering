using System;

public static class Intervals
{
    public static void Main()
    {
        long start = long.Parse(Console.ReadLine());
        long end = long.Parse(Console.ReadLine());
        int count = 0;
        for (long i = start+1; i <= end-1; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}