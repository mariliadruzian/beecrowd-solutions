using System;
using System.Globalization;

// Bee1010 - Cálculo Simples: Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
// Entrada: O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.
// Saída: A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.

class Bee1010
{
    static void Main(string[] args)
    {
        // Entrada Produto 01
        string[] primeiroProd = Console.ReadLine().Split(' ');
        int cod01 = int.Parse(primeiroProd[0]);
        int qtde01 = int.Parse(primeiroProd[1]);
        double preco01 = double.Parse(primeiroProd[2], CultureInfo.InvariantCulture);

        // Entrada Produto 02
        string[] segundoProd = Console.ReadLine().Split(' ');
        int cod02 = int.Parse(segundoProd[0]);
        int qtde02 = int.Parse(segundoProd[1]);
        double preco02 = double.Parse(segundoProd[2], CultureInfo.InvariantCulture);
         
        // Cálculo do total a pagar
        double total = (qtde01 * preco01) + (qtde02 * preco02);

        // Saída
        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
