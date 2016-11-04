using System;
using System.Globalization;

class Age
{
    static void Main()
    {
        Console.WriteLine("Enter your birthdate.");
        DateTime bdate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);
        DateTime now = new DateTime(2016, 3, 3);
        TimeSpan ts = now - bdate;
        DateTime Cage = DateTime.MinValue.AddDays(ts.Days);
        string years = "You are {0} years old ";
        string Fyears = "after 10 years you will be {0} years ";
        int cAge = Cage.Year - 1;
        int fAge = Cage.Year + 9;
        Console.WriteLine(string.Format(years, cAge));
        Console.WriteLine(string.Format(Fyears, fAge));
    }
}