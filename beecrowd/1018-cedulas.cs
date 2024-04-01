using System;

// Bee1018 - Cédulas: Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
// Entrada: O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).
// Saída: Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido.

class Bee1018
{
    static void Main(string[] args)
    {
        // Variáveis
        int N, resto, _cem, _cinquenta, _vinte, _dez, _cinco, _dois, _um;

        // Entrada
        N = int.Parse(Console.ReadLine());

        // Lógica
        _cem = N / 100;
        resto = N % 100;
        _cinquenta = resto / 50;
        resto = resto % 50;
        _vinte = resto / 20;
        resto = resto % 20;
        _dez = resto / 10;
        resto = resto % 10;
        _cinco = resto / 5;
        resto = resto % 5;
        _dois = resto / 2;
        resto = resto % 2;
        _um = resto / 1;

        // Saída
        Console.WriteLine($"{N}");
        Console.WriteLine($"{_cem} nota(s) de R$ 100,00");
        Console.WriteLine($"{_cinquenta} nota(s) de R$ 50,00");
        Console.WriteLine($"{_vinte} nota(s) de R$ 20,00");
        Console.WriteLine($"{_dez} nota(s) de R$ 10,00");
        Console.WriteLine($"{_cinco} nota(s) de R$ 5,00");
        Console.WriteLine($"{_dois} nota(s) de R$ 2,00");
        Console.WriteLine($"{_um} nota(s) de R$ 1,00");
    }
}
