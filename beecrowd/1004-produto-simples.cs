using System;

class Bee1004
{
    static void Main(string[] args)
    {
        int x, y, produto;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        produto = x * y;

        Console.WriteLine($"PROD = {produto}");
    }
}