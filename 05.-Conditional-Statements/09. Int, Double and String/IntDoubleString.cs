using System;

namespace PlayWithIntDoubleAndString
{
    class PlayWithDoubleAndString
    {
        static void Main()
        {

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "integer":
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + 1);
                    break;
                case "real":
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", b + 1.00);
                    break;
                case "text":
                    string c = Console.ReadLine();
                    Console.WriteLine(c + "*");
                    break;
                default: Console.WriteLine("Not correct choice!"); break;
            }
        }
    }
}