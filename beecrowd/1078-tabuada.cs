using System;

class Bee1078
{
    static void Main(string[] args)
    {
        // Variáveis
        int n, i, resultado;

        // Entrada
        n = int.Parse(Console.ReadLine());

        // Aqui validamos de n é maior que 2 e menor que 1000
        while (n <= 2 || n >= 1000)
        {
            n = int.Parse(Console.ReadLine());
        }

        // Saída
        for (i = 1; i <= 10; i++)
        {
            resultado = i * n;
            Console.WriteLine($"{i} x {n} = {resultado}");
        }
    }
}