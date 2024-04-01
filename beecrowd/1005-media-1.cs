using System;
using System.Globalization;

// Bee1005 - Média 1: Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
// Entrada: O arquivo de entrada contém 2 valores com uma casa decimal cada um.
// Saída: Imprima a mensagem "MEDIA" e a média do aluno, com 5 dígitos após o ponto decimal e com um espaço em branco antes e depois da igualdade. Utilize variáveis de dupla precisão (double).

class Bee1005
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        double A, B, media;
        double pesoA = 3.5;
        double pesoB = 7.5;

        // Entrada
        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Cálculo
        media = ((A * pesoA) + (B * pesoB)) / 11;

        // Saída
        Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
    }
}
