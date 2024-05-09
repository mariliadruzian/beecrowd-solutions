using System;

class Bee1165
{
    static void Main(string[] args)
    {
        // Entrada do número de casos
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            // Entrada do valor para validação
            int x = int.Parse(Console.ReadLine());

            // Condição que verifica se o número é primo ou não
            bool primo = true;
            for (int j = 2; j < x; j++)
            {
                if (x % j == 0)
                {
                    primo = false;
                    break;
                }
            }

            // Saída
            if (primo)
            {
                Console.WriteLine($"{x} eh primo");
            }
            else
            {
                Console.WriteLine($"{x} nao eh primo");
            }
        }
    }
}