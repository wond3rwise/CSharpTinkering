using System;

class ModifyBit
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());

        if (p >= 0 && p < 65)
        {
            ulong mask = 1UL << p;
            if (v == 0)
            {

                ulong result = n & ~mask;
                Console.WriteLine(result);

            }
            else if (v == 1)
            {

                ulong result = n | mask;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Oops something went wrong!");
            }
        }
        else
        {
            Console.WriteLine("Oops something went wrong!");
        }


    }
}


