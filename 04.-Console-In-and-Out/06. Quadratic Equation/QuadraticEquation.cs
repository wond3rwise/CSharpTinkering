using System;

public class QuadraticEquation
{
    public static void Main()
    {

        double coefA = double.Parse(Console.ReadLine());
        double coefB = double.Parse(Console.ReadLine());
        double coefC = double.Parse(Console.ReadLine());
        double determinant = (coefB * coefB) - (4 * coefA * coefC);

        if (determinant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (determinant > 0)
        {
            double x1 = (-coefB - Math.Sqrt(determinant)) / (2 * coefA);
            double x2 = (-coefB + Math.Sqrt(determinant)) / (2 * coefA);
            double biggerX = Math.Max(x1, x2);
            double sX = Math.Min(x1, x2);
            Console.WriteLine("{0:F2}", sX);
            Console.WriteLine("{0:F2}", biggerX);
        }
        else
        {
            Console.WriteLine("{0:F2}", (-coefB / (2 * coefA)));
        }

    }
}
