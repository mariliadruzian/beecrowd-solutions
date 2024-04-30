using System;
using System.Globalization;

class Bee1116
{
    static void Main(string[] args)
    {
        // Variáveis
        int n, i, x, y;
        string[] valores;
        double resultado;

        // Entrada
        n = int.Parse(Console.ReadLine());

        // Saída
        for (i = 1; i <= n; i++)
        {
            valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                resultado = (double)x / y;
                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}