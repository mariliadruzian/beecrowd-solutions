using System;
using System.Globalization;

/* 
Bee1045 - Tipos de Triângulos: Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
Se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
Se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
Se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
Se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
Se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
Se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

Entrada: A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

Saída: Imprima todas as classificações do triângulo especificado na entrada. 
 */

class Bee1045
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] valores;
        double v1, v2, v3, a, b, c;

        // Entrada
        valores = Console.ReadLine().Split(' ');
        v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
        v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        // Ordenação
        if (v1 > v2 && v1 > v3 && v2 >= v3)
        {
            a = v1;
            b = v2;
            c = v3;
        }
        else if (v1 > v2 && v1 > v3 && v2 <= v3)
        {
            a = v1;
            b = v3;
            c = v2;
        }
        else if (v2 > v1 && v2 > v3 && v1 >= v3)
        {
            a = v2;
            b = v1;
            c = v3;
        }
        else if (v2 > v1 && v2 > v3 && v1 <= v3)
        {
            a = v2;
            b = v3;
            c = v1;
        }
        else if (v3 > v1 && v3 > v2 && v1 >= v2)
        {
            a = v3;
            b = v1;
            c = v2;
        }
        else
        {
            a = v3;
            b = v2;
            c = v1;
        }

        // Saída
        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            // Testa os ângulos
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
        }

        // Define se é equilátero ou isósceles 
        if (a == b && b == c)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }

        if ((a == b && c != b) || (b == c && a != c) || (c == a && b != a))
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}