using System;


class PointInCircle
{
    static void Main()
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        double circleX = 0;
        double circleY = 0;
        double radius = 2;
        double distance = Math.Sqrt(Math.Pow(pointX - 0, 2) + Math.Pow(pointY - 0, 2));
        double proverka = ((Math.Abs(pointX - circleX)) * (Math.Abs(pointX - circleX)) + (Math.Abs(pointY - circleY)) * (Math.Abs(pointY - circleY)));
        if (proverka <= radius * radius)
        {
            Console.WriteLine("yes {0:F2}", distance);
        }
        else
        {
            Console.WriteLine("no {0:F2}", distance);
        }
    }



}
