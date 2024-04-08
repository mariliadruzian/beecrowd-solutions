using System;
using System.Globalization;

/*
Bee1036 - Fórmula de Bhaskara: Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada: Leia três valores de ponto flutuante (double) A, B e C.

Saída: Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo.
*/

class Bee1036
{
    static void Main(string[] args)
    {
        // Variáveis
        double a, b, c, delta, r1, r2;
        string[] vet;

        // Entrada
        vet = Console.ReadLine().Split(' ');
        a = double.Parse(vet[0], CultureInfo.InvariantCulture);
        b = double.Parse(vet[1], CultureInfo.InvariantCulture);
        c = double.Parse(vet[2], CultureInfo.InvariantCulture);

        // Cálculo do delta
        delta = Math.Pow(b, 2) - (4 * a * c);

        // Condicional + saída
        if (delta <= 0 || a == 0)
        {
            Console.WriteLine("Impossível calcular");
        }
        else
        {
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}