using System;
using System.Globalization;

class Bee1160
{
    static void Main(string[] args)
    {
        // Entrada do número de casos
        int t = int.Parse(Console.ReadLine());

        for (int i = 1; i <= t; i++)
        {
            // Entrada dos dados
            string[] vet = Console.ReadLine().Split(' ');
            int PA = int.Parse(vet[0]);
            int PB = int.Parse(vet[1]);
            double G1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double G2 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            // Condição que calcula os anos até PA se tornar maior que PB
            int totalAnos = 0;
            while (PA <= PB)
            {
                PA += (int)(PA * (G1 / 100));
                PB += (int)(PB * (G2 / 100));
                totalAnos++;
            }

            //Saída
            if (totalAnos > 100)
            {
                Console.WriteLine("Mais de 1 seculo.");
            }
            else
            {
                Console.WriteLine($"{totalAnos} anos.");
            }
        }
    }
}