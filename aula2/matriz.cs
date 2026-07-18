using System;
class Program
{
     static void Main()
    {
        // Matriz de 5 alunos x 5 notas
        int[,] notas = new int[5, 5];
        for(int i = 0; i<5; i++)
        {
            Console.WriteLine($"\nAluno {i + 1}");
            for(int j = 0; j < 5; j++)
            {
                Console.Write($"Digite a nota {j + 1}: ");
                notas[i,j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nMelhor nota de cada aluno:");
        // melhor nota de cada aluno
        for(int i = 0; i<5; i++)
        {
            int maior = notas[i,0];
            for(int j = 1; j < 5; j++)
            {
                if (notas[i, j] > maior)
                {
                    maior = notas[i,j];
                }
            }
            Console.WriteLine($"Aluno {i + 1}: Maior nota = {notas[i,j]}");
        }
    }
    
}