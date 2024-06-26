﻿using System;
using System.Globalization;

// Bee1009 - Salário com Bônus: Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.
// Entrada: O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.
// Saída: Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.

class Bee1009
{
    static void Main(string[] args)
    {
        // Variáveis
        string vendedor;
        double salarioFixo, totalVendas, salarioTotal;

        // Entrada
        vendedor = Console.ReadLine();
        salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Cálculo do salário + comissão de 15%
        salarioTotal = (double) salarioFixo + (totalVendas * 15 / 100);

        // Saída
        Console.WriteLine($"TOTAL = R$ {salarioTotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
