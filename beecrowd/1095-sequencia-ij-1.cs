using System;

class Bee1095
{
    static void Main(string[] args)
    {
        int i = 1;
        for (int j = 60; j >= 0; j -= 5)
        {
            Console.WriteLine($"I={i} J={j}");
            i += 3;
        }
    }
}