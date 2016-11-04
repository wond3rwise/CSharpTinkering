using System;



class ThirdDigit
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = ((a / 100) % 10);
        if (b==7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", b);
        }
    }
        
}
