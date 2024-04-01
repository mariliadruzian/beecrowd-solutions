using System;
using System.Globalization;

/* Bee1012 - Área: 
Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
*/
// Entrada: O arquivo de entrada contém três valores com um dígito após o ponto decimal.
// Saída: O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.

class Bee1012
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] vet;
        double A, B, C, pi = 3.14159, areaTrianguloRet, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

        // Entrada
        vet = Console.ReadLine().Split(' ');
        A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        // Cálculos
        areaTrianguloRet = A * C / 2.0; // base * altura / 2
        areaCirculo = pi * Math.Pow(C, 2.0); // pi * raio ao quadrado
        areaTrapezio = (A + B) * C / 2.0; // soma das bases * altura / 2
        areaQuadrado = (double) B * B; // lado * 2
        areaRetangulo = (double) A * B; // base * altura

        // Saída
        Console.WriteLine($"TRIANGULO: {areaTrianguloRet.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}
