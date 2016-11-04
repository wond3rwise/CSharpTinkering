using System;

    public static class NumbersComparer
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double Big1 = Math.Max(a, b);
            double Big2 = Math.Max(c, Big1);
            Console.WriteLine(Big2);
        }
    }