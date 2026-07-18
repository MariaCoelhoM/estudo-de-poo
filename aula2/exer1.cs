// Faça um programa que receba 5 notas de 5 alunos. O programa deve calcular
//a média de cada aluno
//Utilize uma matriz para este exercício. Armazene, primeiramente, os
//valores na matriz para, em seguida, realizar o cálculo
using System;
class Program
{
    static void Main()
    {
        // Matriz de 5 alunos x 5 notas
        int[,] notas = new int[5, 5];

        // Entrada das notas
        for (int i = 0; i < 5; i++) // percorre os alunos
        {
            Console.WriteLine($"\nAluno {i + 1}");

            for (int j = 0; j < 5; j++) // percorre as notas do aluno
            {
                Console.Write($"Digite a nota {j + 1}: ");
                notas[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMédias dos alunos:");

        // Cálculo da média de cada aluno
        for (int i = 0; i < 5; i++)
        {
            int soma = 0;

            for (int j = 0; j < 5; j++)
            {
                soma += notas[i, j];
            }

            double media = soma / 5.0;

            Console.WriteLine($"Aluno {i + 1}: Média = {media}");
        }
    }
}