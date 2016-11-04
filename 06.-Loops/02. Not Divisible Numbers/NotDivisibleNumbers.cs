using System;


class NotDivisibleNumbers
{
    static void Main()
    {
        //Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i <= number; i++)
        {
            if ((i % 7 == 0) || (i % 3 == 0))
            {
                continue;
            }
            Console.Write(i + " ");
        }

    }
}
