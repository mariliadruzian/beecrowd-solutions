using System;

class Bee1047
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] valores;
        int horaInicial, minutoInicial, horaFinal, minutoFinal, somatoriaInicial, somatoriaFinal, totalHoras, totalMinutos, duracao;

        // Entrada
        valores = Console.ReadLine().Split(' ');
        horaInicial = int.Parse(valores[0]);
        minutoInicial = int.Parse(valores[1]);
        horaFinal = int.Parse(valores[2]);
        minutoFinal = int.Parse(valores[3]);

        // Cálculo
        somatoriaInicial = horaInicial * 60 + minutoInicial;
        somatoriaFinal = horaFinal * 60 + minutoFinal;

        // Condicional
        if (somatoriaInicial < somatoriaFinal)
        {
            duracao = somatoriaFinal - somatoriaInicial;
        }
        else
        {
            duracao = (24 * 60 - somatoriaInicial) + somatoriaFinal;
        }

        totalHoras = duracao / 60;
        totalMinutos = duracao % 60;

        // Saída
        Console.WriteLine($"O JOGO DUROU {totalHoras} HORA(S) E {totalMinutos} MINUTO(S)");
    }
}