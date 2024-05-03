using System;
using System.Globalization;

class Bee1155
{
    static void Main(string[] args)
    {
        double s = 1.0;

        for (int i = 2; i <= 100; i++)
        {
            s += (double)1 / i;
        }

        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
    }
}