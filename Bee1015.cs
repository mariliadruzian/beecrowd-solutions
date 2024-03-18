using System;
using System.Globalization;

// Bee1015 - Distância Entre Dois Pontos: Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula
// Fórmula: Distância = √(x2 - x1)^2 + (y2 - y1)^2
// Entrada: O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2
// Saída: Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal

class Bee1015
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        double x1, x2, y1, y2, distancia;

        // Entrada
        string[] vet = Console.ReadLine().Split(' ');
        x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

        vet = Console.ReadLine().Split(' ');
        x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

        // Cálculo
        distancia = Math.Sqrt((Math.Pow((x2 - x1), 2)) + Math.Pow((y2 - y1), 2));

        // Saída
        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
    }
}