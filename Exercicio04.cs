using System;
using System.Globalization;

// Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas. Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas, com uma casa decimal, conforme exemplo.

class Exercicio04
{
    static void Main(string[] args)
    {
        // Criação do vetor para fazer a leitura da linha
        string[] pessoa;
         
        // Entrada de dados Pessoa01
        pessoa = Console.ReadLine().Split(' ');
        string nome01 = pessoa[0];
        int idade01 = int.Parse(pessoa[1]);

        // Entrada de dados Pessoa02
        pessoa = Console.ReadLine().Split(' ');
        string nome02 = pessoa[0];
        int idade02 = int.Parse(pessoa[1]);

        // Calculo da idade média com uso de casting
        double idadeMedia = (double) (idade01 + idade02) / 2;

        // Saída
        Console.WriteLine($"A idade média de {nome01} e {nome02} é de {idadeMedia.ToString("F1", CultureInfo.InvariantCulture)} anos.");
    }
}