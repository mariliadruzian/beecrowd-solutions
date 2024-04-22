using System;

class Bee1114
{
    static void Main(string[] args)
    {
        // Variável que guarda a senha correta
        int senha = 2002;
        
        // Variável que lê a entrada do usuário
        int entrada = int.Parse(Console.ReadLine());

        // Estrutura que valida se a entrada é diferente da senha correta
        while (entrada != senha)
        {
            Console.WriteLine("Senha Invalida");
            entrada = int.Parse(Console.ReadLine());
        }

        // Saída para a senha correta
        Console.WriteLine("Acesso Permitido");
    }
}