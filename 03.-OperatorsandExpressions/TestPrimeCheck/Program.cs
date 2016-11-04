using System;

class PrimeNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number <= 1)
        {
            Console.WriteLine("false");
        }
        else
        {
            int primeCount = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    primeCount++;
                }
            }
            string isPrime = "true";
            if (primeCount > 2)
            {
                isPrime = "false";
            }

            Console.WriteLine("{0}", isPrime);
        }
    }
}