using System;

class Bee1113
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] vet;
        int x, y;

        // Entrada
        vet = Console.ReadLine().Split(' ');
        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);

        // Estrutura repetitiva
        while (x != y)
        {
            if (x > y)
            {
                Console.WriteLine("Decrescente");
            }
            else
            {
                Console.WriteLine("Crescente");
            }
            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
        }
    }
}