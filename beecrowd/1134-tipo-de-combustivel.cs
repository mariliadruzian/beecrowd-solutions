using System;

class Bee1134
{
    static void Main(string[] args)
    {
        // Variáveis
        int codigo, alcool = 0, gasolina = 0, diesel = 0;

        // Entrada
        codigo = int.Parse(Console.ReadLine());

        // Enquando o primeiro código for < 1 ou > 4 solicitamos um novo código
        while (codigo < 1 || codigo > 4)
        {
            codigo = int.Parse(Console.ReadLine());
        }

        // Enquanto o código for >= 1 e < 4 vamos incrementar os produtos conforme o código inserido e na sequência solicitar o próximo, que enquanto estiver fora da faixa 1-4 vai soliciar uma nova entrada. Caso a entrada seja o 4, a estrutura principal vai dar 'false' e sair da estrutura para executar a saída
        while (codigo >= 1 && codigo < 4)
        {
            if (codigo == 1)
            {
                alcool++;
            }
            else if (codigo == 2)
            {
                gasolina++;
            }
            else if (codigo == 3)
            {
                diesel++;
            }
            codigo = int.Parse(Console.ReadLine());
            while (codigo < 1 || codigo > 4)
            {
                codigo = int.Parse(Console.ReadLine());
            }
        }

        // Saída
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}
