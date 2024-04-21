using System;
using System.Globalization;

class Bee1064
{
    static void Main(string[] args)
    {
        // Variáveis
        double n1, n2, n3, n4, n5, n6, total = 0, media;
        int cont = 0;

        // Entrada
        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Essa condicional valida se o número é positivo e adiciona o valor a variável "total"
        // Se for positivo a variável "cont" é incrementada e o valor é adicionado a variável "total"
        if (n1 > 0)
        {
            cont++;
            total += n1;
        }
        if (n2 > 0)
        {
            cont++;
            total += n2;
        }
        if (n3 > 0)
        {
            cont++;
            total += n3;
        }
        if (n4 > 0)
        {
            cont++;
            total += n4;
        }
        if (n5 > 0)
        {
            cont++;
            total += n5;
        }
        if (n6 > 0)
        {
            cont++;
            total += n6;
        }

        // A variável média recebe a somatória dos positivos e divide pela quantidade de positivos
        media = (double) total / cont;

        // Saída
        Console.WriteLine($"{cont} valores positivos");
        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
}