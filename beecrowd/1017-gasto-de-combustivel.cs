using System;
using System.Globalization;

// Bee1017 - Gasto de Combustível: Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar um automóvel que faz 12 KM/L. Para isso, ele gostaria que você o auxiliasse através de um simples programa. Para efetuar o cálculo, deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). Assim, pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.
// Entrada: O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem (em horas) e o segundo é a velocidade média durante a mesma (em km/h).
// Saída: Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal.

class Bee1017
{
    static void Main(string[] args)
    {
        // Entrada
        int tempoGasto = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());

        // Calculo da distância
        int distancia = tempoGasto * velocidadeMedia;

        // Calculo da quantidade de litros necessários para a viagem
        // Aqui podemos fazer o casting colocando o (double) para reafirmar o tipo da variável ou colocar 12.0
        double litrosNecessarios = (double) distancia / 12;

        // Saída
        Console.WriteLine($"{litrosNecessarios.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}