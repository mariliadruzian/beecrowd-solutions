using System;

/*
Bee 1044 - Múltiplos: Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

Entrada: A entrada contém valores inteiros.

Saída: A saída deve conter uma das mensagens conforme descrito acima.
*/

class Bee1044
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] valores;
        int x, y;

        // Entrada
        valores = Console.ReadLine().Split(' ');
        x = int.Parse(valores[0]);
        y = int.Parse(valores[1]);

        // Condicional
        if (x % y == 0 || y % x == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}
