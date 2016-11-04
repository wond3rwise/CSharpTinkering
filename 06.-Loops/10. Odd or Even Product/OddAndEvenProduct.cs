using System;


class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        string[] newInputArray = new string[n];

        for (int i = 0; i < n; i++)
        {
            newInputArray[i] = inputArray[i];
        }

        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < newInputArray.Length; i++)
        {
            int number = int.Parse(newInputArray[i]);
            if (i % 2 == 0 || i == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}