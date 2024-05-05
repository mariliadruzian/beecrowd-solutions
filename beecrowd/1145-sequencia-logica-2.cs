using System;

class Bee1145
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');
        int x = int.Parse(vet[0]);
        int y = int.Parse(vet[1]);

        int cont = 0;
        for (int i = 1; i <= y; i++)
        {
            Console.Write($"{i}");
            cont++;

            if (cont == x)
            {
                Console.WriteLine();
                cont = 0;
            }
            else
            {
                Console.Write(' ');
            }
        }
    }
}