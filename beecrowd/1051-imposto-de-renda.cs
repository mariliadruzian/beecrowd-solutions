using System;
using System.Globalization;

class Bee1051
{
    static void Main(string[] args)
    {
        // Variáveis
        double salario, basedecalc, imposto;

        // Entrada
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Saída
        if (salario <= 2000.0)
        {
            Console.WriteLine("Isento");
        }
        else if (salario > 2000.0 && salario <= 3000.0)
        {
            basedecalc = (salario - 2000.0);
            imposto = basedecalc * 8 / 100;
            Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else if (salario > 3000.0 && salario <= 4500.0)
        {
            basedecalc = (salario - 3000.0);
            imposto = (basedecalc * 18 / 100) + (1000.0 * 8 / 100);
            Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            basedecalc = (salario - 4500.0);
            imposto = (basedecalc * 28 / 100) + (1500.0 * 18 / 100) + (1000.0 * 8 / 100);
            Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}