using System;

// Bee1021 - Notas e Moedas: Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.
// Entrada: O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).
// Saída: Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido. Obs: Utilize ponto (.) para separar a parte decimal. 

class Bee1021
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        int nInteiro, nDecimal, resto;
        int notaCem, notaCinquenta, notaVinte, notaDez, notaCinco, notaDois, moedaUmReal, moedaCinquenta, moedaVinteECinco, moedaDez, moedaCinco, moedaUmCent;

        // Entrada: A ideia aqui é ler a entrada do usuário e fazer um split através do ponto
        // Logo, teremos dois valores armazenados no vetor, o inteiro e o decimal
        string[] vet = Console.ReadLine().Split('.');
        nInteiro = int.Parse(vet[0]);
        nDecimal = int.Parse(vet[1]);

        // Cálculo Notas
        notaCem = nInteiro / 100;
        resto = nInteiro % 100;
        notaCinquenta = resto / 50;
        resto = resto % 50;
        notaVinte = resto / 20;
        resto = resto % 20;
        notaDez = resto / 10;
        resto = resto % 10;
        notaCinco = resto / 5;
        resto = resto % 5;
        notaDois = resto / 2;

        // Cálculo Moedas
        moedaUmReal = resto % 2;
        moedaCinquenta = nDecimal / 50;
        resto = nDecimal % 50;
        moedaVinteECinco = resto / 25;
        resto = resto % 25;
        moedaDez = resto / 10;
        resto = resto % 10;
        moedaCinco = resto / 5;
        moedaUmCent = resto % 5;

        // Saída NOTAS
        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{notaCem} nota(s) de R$ 100.00");
        Console.WriteLine($"{notaCinquenta} nota(s) de R$ 50.00");
        Console.WriteLine($"{notaVinte} nota(s) de R$ 20.00");
        Console.WriteLine($"{notaDez} nota(s) de R$ 10.00");
        Console.WriteLine($"{notaCinco} nota(s) de R$ 5.00");
        Console.WriteLine($"{notaDois} nota(s) de R$ 2.00");

        // Saída MOEDAS
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{moedaUmReal} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moedaCinquenta} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moedaVinteECinco} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moedaDez} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moedaCinco} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moedaUmCent} moeda(s) de R$ 0.01");
    }
}
