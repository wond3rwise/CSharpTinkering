using System;


class HexToDecimal
{
    static void Main()
    {
        string hexadecimal = Console.ReadLine();
        long result = 0;

        for (int i = 0; i < hexadecimal.Length; i++)
        {

            if (hexadecimal[hexadecimal.Length - i - 1] >= '0' && hexadecimal[hexadecimal.Length - i - 1] <= '9')
            {
                result += ((hexadecimal[hexadecimal.Length - i - 1] - '0') * (long)Math.Pow(16, i));
            }
            else if (hexadecimal[hexadecimal.Length - i - 1] == 'D')
            {
                result += (13 * (long)Math.Pow(16, i));
            }
            else if (hexadecimal[hexadecimal.Length - i - 1] == 'C')
            {
                result += (12 * (long)Math.Pow(16, i));
            }
            else if (hexadecimal[hexadecimal.Length - i - 1] == 'A')
            {
                result += (10 * (long)Math.Pow(16, i));
            }
            else if (hexadecimal[hexadecimal.Length - i - 1] == 'B')
            {
                result += (11 * (long)Math.Pow(16, i));
            }
            else if (hexadecimal[hexadecimal.Length - i - 1] == 'F')
            {
                result += (15 * (long)Math.Pow(16, i));
            }
            else if (hexadecimal[hexadecimal.Length - i - 1] == 'E')
            {
                result += (14 * (long)Math.Pow(16, i));
            }

        }
        Console.WriteLine(result);
    }

}



