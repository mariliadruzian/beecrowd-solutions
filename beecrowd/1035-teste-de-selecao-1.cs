using System;

/* 
Bee1035 - Teste de Seleção 1: Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

Entrada: Quatro números inteiros A, B, C e D.

Saída: Mostre a respectiva mensagem após a validação dos valores.
 */

class Bee1035
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] valores;
        int a, b, c, d;

        // Entrada
        // O vetor vai pegar os dados inseridos na mesma linha e alocar nas posições 0, 1, 2, 3 
        valores = Console.ReadLine().Split(' ');
        a = int.Parse(valores[0]);
        b = int.Parse(valores[1]);
        c = int.Parse(valores[2]);
        d = int.Parse(valores[3]);

        // Condicional
        if (b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        } 
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}
