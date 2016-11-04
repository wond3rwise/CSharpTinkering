using System;
using System.Numerics;

class CalculateFactorialsDivision
{
    static void Main()
    {

        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());


        BigInteger resultDivision = 1;
        for (int i = numN; i > numK; i--)
        {
            resultDivision *= i;
        }
        Console.WriteLine(resultDivision);


    }
}