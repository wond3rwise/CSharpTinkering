using System;

class FibonacciNumbers
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long[] array = new long[n];
        long a = 0;
        long b = 1;
        for (long i = 0; i < n; i++)
        {
            array[i] = a;
            long tmp = b;
            b = a + b;
            a = tmp;
        }
        String asd = String.Join(", ", array);
        Console.WriteLine(asd);
    }
}
