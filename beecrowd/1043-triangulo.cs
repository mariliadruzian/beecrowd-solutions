using System;
using System.Globalization;

class Bee1043
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] vet;
        double a, b, c, perimetro, area;

        // Entrada
        vet = Console.ReadLine().Split(' ');
        a = double.Parse(vet[0], CultureInfo.InvariantCulture);
        b = double.Parse(vet[1], CultureInfo.InvariantCulture);
        c = double.Parse(vet[2], CultureInfo.InvariantCulture);

        // Condição de existência de um triângulo
        if (a < b + c && b < a + c && c < a + b)
        {
            perimetro = a + b + c;
            Console.WriteLine($"Perimetro = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
        }
        else
        {
            area = (a + b) / 2 * c;
            Console.WriteLine($"Area = {area.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}