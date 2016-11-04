using System;
using System.Numerics;


class BinaryToDecimal
{
    static void Main()
    {
        BigInteger binary = BigInteger.Parse(Console.ReadLine());
        double result = 0;
        double calc = 0;
        double pow = 0;
        do
        {
            if (binary % 10 == 0)
            {
                result = result + 0;
                pow++;
                binary = binary / 10;
            }
            else
            {
                calc = Math.Pow(2, pow);
                result = result + calc;
                binary = binary / 10;
                pow++;
            }
        } while (binary > 0);
        Console.WriteLine(result);

    }
}

