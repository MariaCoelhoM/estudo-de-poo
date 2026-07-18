//Faça um programa que receba 5 notas de apenas 1 aluno. O programa deve
//calcular a média desse aluno.
//Utilize uma lista para este exercício. Armazene, primeiramente, os valores
//na lista para, em seguida, realizar o cálculo.
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> notas = new List<int>();
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nNotas: {i + 1}");
            notas.Add(int.Parse(Console.ReadLine()));
        }
        
        Console.WriteLine("\nMédia dos aluno:");

        // Cálculo da média de cada aluno
        int soma = 0;

        for (int i = 0; i < notas.Count; i++)
        {
            soma += notas[i];
        }

        // Calcula a média
        double media = soma / 5.0;
        Console.WriteLine($"\nMédia do aluno: {media}");
    }
    
}
