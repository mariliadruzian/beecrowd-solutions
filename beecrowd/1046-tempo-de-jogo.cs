using System;

/*
Bee 1046 - Tempo de Jogo: Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

Entrada: A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

Saída: Apresente a duração do jogo conforme exemplo abaixo.
*/

class Bee1046
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] valores;
        int horaInicial, horaFinal, duracao;

        // Entrada
        valores = Console.ReadLine().Split(' ');
        horaInicial = int.Parse(valores[0]);
        horaFinal = int.Parse(valores[1]);

        // Condicional
        if (horaInicial < horaFinal)
        {
            duracao = horaFinal - horaInicial;
        }
        else
        {
            duracao = (24 - horaInicial) + horaFinal;
        }

        // Saída
        Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
    }
}