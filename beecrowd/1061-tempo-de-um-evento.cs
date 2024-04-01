using System;

/*
Bee1061 - Tempo de um Evento: Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento. Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.

Entrada: Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.

Saída: Na saída, deve ser apresentada a duração do evento, no seguinte formato:
W dia(s)
X hora(s)
Y minuto(s)
Z segundo(s)
Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
*/

class Bee1061
{
    static void Main(string[] args)
    {
        // Variáveis
        int iniDia, iniHora, iniMinuto, iniSegundo; // Armazena a data inicial do evento
        int fimDia, fimHora, fimMinuto, fimSegundo; // Armazena a data final do evento
        int totalDia, totalHora, totalMin, totalSeg; // Armazena a duração do evento
        string[] vet; // Coleta os dados de entrada
        int resto; // Armazena o resto da divisão

        // Entrada da data e hora inicial do evento
        vet = Console.ReadLine().Split(' ');
        iniDia = int.Parse(vet[1]);

        vet = Console.ReadLine().Split(':');
        iniHora = int.Parse(vet[0]);
        iniMinuto = int.Parse(vet[1]);
        iniSegundo = int.Parse(vet[2]);

        // Entrada da data e hora final do evento
        vet = Console.ReadLine().Split(' ');
        fimDia = int.Parse(vet[1]);

        vet = Console.ReadLine().Split(':');
        fimHora = int.Parse(vet[0]);
        fimMinuto = int.Parse(vet[1]);
        fimSegundo = int.Parse(vet[2]);

        // Cálculo 1: A ideia aqui é transformar o período total do evento em segundos
        int soma = (((((fimDia - iniDia) * 24) + (fimHora - iniHora)) * 60) * 60) + (((fimMinuto - iniMinuto) * 60) + (fimSegundo - iniSegundo));

        // Cálculo 2: Aqui vamos dividir a duração total (em segundos) nas variáveis totalDia, totalHora, totalMin, totalSeg 
        totalDia = soma / 86400; // 86.400 seg = 24 horas
        resto = soma % 86400;
        totalHora = resto / 3600; // 3.600 seg = 1 hora
        resto = resto % 3600;
        totalMin = resto / 60; // 60 seg = 1 minuto
        totalSeg = resto % 60;

        // Saída 
        Console.WriteLine($"{totalDia} dia(s)");
        Console.WriteLine($"{totalHora} hora(s)");
        Console.WriteLine($"{totalMin} minuto(s)");
        Console.WriteLine($"{totalSeg} segundo(s)");
    }
}
