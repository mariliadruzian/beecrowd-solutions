﻿using System;

// Bee1007 - Diferença: Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
// Entrada: O arquivo de entrada contém 4 valores inteiros.
// Saída: Imprima a mensagem "DIFERENCA = " com todas as letras maiúsculas e com um espaço em branco antes e depois da igualdade.

class Bee1007
{
    static void Main(string[] args)
    {
        int A, B, C, D, dif;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());

        dif = (A * B) - (C * D);

        Console.WriteLine($"DIFERENCA = {dif}");
    }
}
