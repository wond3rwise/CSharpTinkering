﻿using System;

public static class SumOfN
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        decimal sum = 0.00m;
        decimal number = decimal.MinValue;
        for (int i = 0; i < n; i++)
        {
            number = decimal.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}

