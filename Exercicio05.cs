using System;
using System.Globalization;

// Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro casas decimais.

class Exercicio05
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        double area, perimetro, diagonal, baseRetangulo, alturaRetangulo;

        // Entrada da base e altura
        baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     
        
        // Cálculo
        area = baseRetangulo * alturaRetangulo;
        perimetro = 2 * (baseRetangulo + alturaRetangulo);
        diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(alturaRetangulo, 2));

        // Saída
        Console.WriteLine($"AREA = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"PERIMETRO = {perimetro.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"DIAGONAL = {diagonal.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}