using System;

class Bee1158
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            if (x % 2 == 0)
            {
                x++;
            }

            int soma = 0;
            int cont = 1;

            for (int j = x; cont <= y; j += 2)
            {
                soma += j;
                cont++;
            }

            Console.WriteLine(soma);
        }
    }
}