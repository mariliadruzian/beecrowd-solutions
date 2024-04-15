using System;

class Bee1049
{
    static void Main(string[] args)
    {
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();

        if (x == "vertebrado")
        {
            if (y == "ave")
            {
                if (z == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else
                {
                    Console.WriteLine("pomba");
                }
            }
            else
            {
                if (z == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        else
        {
            if (y == "inseto")
            {
                if (z == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else
                {
                    Console.WriteLine("lagarta");
                }
            }
            else
            {
                if (z == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}