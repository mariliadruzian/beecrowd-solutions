using System;
using System.Globalization;

/* 
Bee1038 - Lanche: Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

Entrada: O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

Saída: O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
 */

class Bee1038
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] valores;
        int codigo, qtde;
        double total = 0.0;

        // Entrada
        valores = Console.ReadLine().Split(' ');
        codigo = int.Parse(valores[0]);
        qtde = int.Parse(valores[1]);

        // Condicional
        switch (codigo)
        {
            case 1:
                total = qtde * 4.0;
                break;
            case 2:
                total = qtde * 4.5;
                break;
            case 3:
                total = qtde * 5.0;
                break;
            case 4:
                total = qtde * 2.0;
                break;
            case 5:
                total = qtde * 1.5;
                break;
        }

        // Saída
        Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}