using System;
using System.Globalization;

// Bee1014 - Consumo: Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em km) e o total de combustível gasto (em litros).
// Entrada: O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em km), e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.
// Saída: Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".

class Bee1014
{
    static void Main(string[] args)
    {
        // Recebe os valores de distância e combustível gasto
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Calcula o consumo médio
        double consumoMedio = x / y;

        // Saída
        Console.WriteLine($"{consumoMedio.ToString("F3", CultureInfo.InvariantCulture)} km/l");
    }
}