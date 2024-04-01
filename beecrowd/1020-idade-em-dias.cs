using System;

// Bee1020 - Idade em Dias: Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias. Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
// Entrada: O arquivo de entrada contém um valor inteiro.
// Saída: Imprima a saída conforme exemplo fornecido.

class Bee1020
{
    static void Main(string[] args)
    {
        // Variáveis
        int idadeEmDias, anos, meses, dias, resto;

        // Entrada
        idadeEmDias = int.Parse(Console.ReadLine());

        // Lógica
        anos = idadeEmDias / 365;
        resto = idadeEmDias % 365;
        meses = resto / 30;
        dias = resto % 30;

        // Saída
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}
