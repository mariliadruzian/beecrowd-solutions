using System;

class Bee1131
{
    static void Main(string[] args)
    {
        // Variáveis
        int golsInter, golsGremio;
        int novoGrenal = 1;
        int cont = 0;
        int vitoriasGremio = 0;
        int vitoriasInter = 0;
        int empates = 0;
        string[] vet;

        // Estrutura
        while (novoGrenal == 1)
        {
            vet = Console.ReadLine().Split(' ');
            golsInter = int.Parse(vet[0]);
            golsGremio = int.Parse(vet[1]);
            cont++;

            if (golsGremio > golsInter)
            {
                vitoriasGremio++;
            }
            else if (golsGremio < golsInter)
            {
                vitoriasInter++;
            }
            else
            {
                empates++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            novoGrenal = int.Parse(Console.ReadLine());

            while (novoGrenal != 1 && novoGrenal != 2)
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }
        }

        // Saída
        Console.WriteLine($"{cont} grenais");
        Console.WriteLine($"Inter:{vitoriasInter}");
        Console.WriteLine($"Gremio:{vitoriasGremio}");
        Console.WriteLine($"Empates:{empates}");

        if (vitoriasInter > vitoriasGremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if (vitoriasInter < vitoriasGremio)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }
    }
}