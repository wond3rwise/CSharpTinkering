using System;

namespace ConsoleInputOutput
{
    public static class NumbersComparer
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double desiredNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine(desiredNumber);
        }
    }
}