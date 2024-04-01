using System;

// Bee1019 - Conversão de Tempo: Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.
// Entrada: O arquivo de entrada contém um valor inteiro N.
// Saída: Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

class Bee1019
{
    static void Main(string[] args)
    {
        // Entrada
        int N = int.Parse(Console.ReadLine());

        // Cálculo
        int horas = N / 3600;
        int resto = N % 3600;
        int minutos = resto / 60;
        int segundos = resto % 60;

        // Saída
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}