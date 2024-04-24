using System;
using System.Globalization;

class Bee1118
{
    static void Main(string[] args)
    {
        // Variáveis
        double nota1, nota2, media;
        int novoCalculo = 1;

        // Estrutura principal
        while (novoCalculo == 1)
        {
            // Entrada nota 1
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            // Entrada nota 2
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            // Calcula e exibe a média
            media = (nota1 + nota2) / 2.0;
            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");

            // Solicita código para novo cálculo
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            novoCalculo = int.Parse(Console.ReadLine());

            /* Aqui a estrutura dá 2 opções
             * Código 1: o while principal repete toda a execução
             * Código 2: o while principal encerra a execução */
            while (novoCalculo != 1 && novoCalculo != 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());
            }
        }
    }
}