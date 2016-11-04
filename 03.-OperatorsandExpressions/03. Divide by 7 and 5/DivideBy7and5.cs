using System;


class DivideBy7and5
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        if ((a % 5 == 0) && (a % 7 == 0))
        {
            Console.WriteLine("true {0}", a);
        }
        else
        {
            Console.WriteLine("false {0}", a);
        }
    }
}

