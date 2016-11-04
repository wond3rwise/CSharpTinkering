using System;



class ComparingFloats
{
    static void Main()
    {
        Console.Write("enter a dacimal a=");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("a={0}",a);
        Console.Write("enter a dacimal b=");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("b={0}",b);
        double eps =0.000001f;
        double ab = Math.Abs(a - b);
        Console.WriteLine("diff={0}",ab);
        if (ab == 0 || ab < eps)
        {
            bool result = true;
            Console.WriteLine(result);
            Console.WriteLine("The difference {0} < eps", ab);
        }
        else if (ab > eps)
        {
            bool result = false;
            Console.WriteLine(result);
            Console.WriteLine("The difference of {0} is too big", ab);
        }
        else 
        {
            bool result = false;
            Console.WriteLine(result);
            Console.WriteLine("Border case {0}==eps", ab);
        }

    }
}

