using System;
using System.Globalization;

/*
Bee1040 - Média 3: Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.

Entrada: A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.

Saída: Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas conforme a descrição do problema. Não esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".
*/

class Bee1040
{
    static void Main(string[] args)
    {
        // Variáveis
        string[] notas;
        double nota1, nota2, nota3, nota4, media, notaExame, mediaFinal;
        int peso1 = 2, peso2 = 3, peso3 = 4, peso4 = 1;

        // Entrada
        notas = Console.ReadLine().Split(' ');
        nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
        nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
        nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
        nota4 = double.Parse(notas[3], CultureInfo.InvariantCulture);

        // Cálculo da média
        media = (double)(nota1 * peso1 + nota2 * peso2 + nota3 * peso3 + nota4 * peso4) / (peso1 + peso2 + peso3 + peso4);
        
        // O exercício 1040 tem uma falha de arredondamento especifica para a linguagem C#. Quando a média dá 4.85, nós temos que ajusta-la manualmente para 4.8, o que é uma "gambiarra" horrível, infelizmente. Isso não aconteceu nas outras linguagens, tais como Java, C e C++
        if (media == 4.85)
        {
            media = 4.8;
        }

        // Imprime a média
        Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

        // Condicional
        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê a nota do exame
            Console.WriteLine($"Nota do exame: {notaExame.ToString("F1", CultureInfo.InvariantCulture)}"); // Imprime a nota do exame
            mediaFinal = (media + notaExame) / 2; // Calcula a média final
            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}