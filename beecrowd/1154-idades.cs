using System;
using System.Globalization;

class Bee1154
{
    static void Main(string[] args)
    {
        int idade, soma = 0, cont = 0;
        double media;

        idade = int.Parse(Console.ReadLine());

        while (idade >= 0)
        {
            soma += idade;
            cont++;
            idade = int.Parse(Console.ReadLine());
        }

        media = (double) soma / cont;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}