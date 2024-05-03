using System;
using System.Globalization;

class Bee1156
{
    static void Main(string[] args)
    {
        double s = 1;
        int x = 2;

        for (int i = 3; i <= 39; i += 2)
        {
            s += (double)i / x;
            x += x;
        }

        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
    }
}