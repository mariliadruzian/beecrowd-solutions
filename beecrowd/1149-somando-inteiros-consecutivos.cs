using System;

class Bee1149
{
    static void Main(string[] args)
    {
        // Variáveis
        int a, n, j, i, sum = 0;

        // Entrada        
        string[] vet = Console.ReadLine().Split(' ');

        // Recebe os dois primeiros valores do vetor
        a = int.Parse(vet[0]);
        n = int.Parse(vet[1]);

        // Caso o "n" seja <= 0 vamos percorrer as posições do vetor até encontrar um valor > 0 e atribui-lo a variável "n"
        for (j = 2; n <= 0; j++) 
        {
            n = int.Parse(vet[j]);
        }

        // Aqui faremos a soma de a + i para cada i com os valores (0 <= i <= n - 1)
        for (i = 0; i <= n - 1; i++)
        {
            sum += a + i;
        }

        // Saída
        Console.WriteLine(sum);
    }
}