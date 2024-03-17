using System;
using System.Globalization;

// Bee1002 - Área do Círculo
// Entrada: A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.
// Saída: Apresentar a mensagem "A=" seguido pelo valor da variável area, com 4 casas após o ponto decimal. Utilize variáveis de dupla precisão (double).

class Bee1002
{
    static void Main(string[] args) 
    {
        double pi = 3.14159;
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double area = Math.Pow(raio, 2) * pi;

        Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.ReadLine();
    }

}