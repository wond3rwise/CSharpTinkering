using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {

        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());

        BigInteger factorialNtoK = 1;
        for (int i = numN; i > numK; i--)
        {
            factorialNtoK *= i;
        }

        BigInteger dividerFactorial = 1;
        for (int j = 2; j <= (numN - numK); j++)
        {
            dividerFactorial *= j;
        }

        BigInteger resultDivision = factorialNtoK / dividerFactorial;
        Console.WriteLine(resultDivision);

    }
}