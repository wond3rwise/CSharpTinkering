using System;

public class Program
{
    public static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double P = Math.PI * 2 * r;
        double S = Math.PI * r * r;
        Console.WriteLine("{0:F2} {1:F2}", P, S);
       
    }
}