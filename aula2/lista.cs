//Crie um programa que receba 8 notas de um aluno utilizando uma List<int>.
//Depois de armazenar todas as notas, o programa deve mostrar:
//A maior nota
//A menor nota

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> notas = new List<int>();
        for(int i = 0; i < 8; i++)
        {
            Console.WriteLine($"\nNotas: {i + 1}");
            notas.Add(int.Parse(Console.ReadLine()));
        }
        
        Console.WriteLine("\nMédia dos aluno:");

        // Cálculo da média de cada aluno
        int maior = notas[0];
        int menor = notas[0];
        for(int i = 0; i < notas.Count; i++)
        {
            if (notas[i] > maior)
            {
                maior = notas[i];
            }
            else if(notas[i] < menor)
            {
                menor = notas[i];
            }
        }

        Console.WriteLine($"A maior nota do aluno: {maior}");
        Console.WriteLine($"A menor nota do aluno {menor}");
    }
    
}
