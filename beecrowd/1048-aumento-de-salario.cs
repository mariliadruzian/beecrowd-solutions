﻿using System;
using System.Globalization;

/*
Bee 1048 - Aumento de Salário: A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo. Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

Entrada: A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída: Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste (ambos devem ser apresentados com 2 casas decimais) e o percentual de reajuste ganho, conforme exemplo abaixo.
*/

class Bee1048
{
    static void Main(string[] args)
    {
        // Variáveis
        double salario, novoSalario, reajuste, percentual;

        // Entrada
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Condicional
        if (salario <= 400.0)
        {
            percentual = 15.0;
        }
        else if (salario <= 800.0)
        {
            percentual = 12.0;
        }
        else if (salario <= 1200.0)
        {
            percentual = 10.0;
        }
        else if (salario <= 2000.0)
        {
            percentual = 7.0;
        }
        else
        {
            percentual = 4.0;
        }

        // Cálculo
        reajuste = (double) salario * percentual / 100;
        novoSalario = salario + reajuste;

        // Saída
        Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Em percentual: {percentual.ToString("F0", CultureInfo.InvariantCulture)} %");
    }
}