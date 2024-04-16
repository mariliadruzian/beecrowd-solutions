using System;

class Bee1042
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] valores;
        int n1, n2, n3, a, b, c;

        // Entrada
        valores = Console.ReadLine().Split(' ');
        n1 = int.Parse(valores[0]);
        n2 = int.Parse(valores[1]);
        n3 = int.Parse(valores[2]);

        // Ordenação
        if (n1 < n2 && n1 < n3 && n2 <= n3)
        {
            a = n1;
            b = n2;
            c = n3;
        }
        else if (n1 < n2 && n1 < n3 && n2 >= n3)
        {
            a = n1;
            b = n3;
            c = n2;
        }
        else if (n2 < n1 && n2 < n3 && n1 <= n3)
        {
            a = n2;
            b = n1;
            c = n3;
        }
        else if (n2 < n1 && n2 < n3 && n1 >= n3)
        {
            a = n2;
            b = n3;
            c = n1;
        }
        else if (n3 < n1 && n3 < n2 && n1 <= n2)
        {
            a = n3;
            b = n1;
            c = n2;
        }
        else
        {
            a = n3;
            b = n2;
            c = n1;
        }

        // Saída
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine();
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
    }
}