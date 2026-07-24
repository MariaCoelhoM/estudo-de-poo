using System;

class Program
{
    static void Main()
    {
        // Cria um vetor com 5 posições
        int[] numeros = new int[5];

        // Lê os 5 números usamos o numeros.Length.
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Inicializa Maior e Menor com o primeiro número do vetor
        int Maior = numeros[0];
        int Menor = numeros[0];

        // Percorre o vetor para descobrir o maior e o menor
        for (int i = 1; i < numeros.Length; i++)
        {
            // Verifica se encontrou um número maior
            if (numeros[i] > Maior)
            {
                Maior = numeros[i];
            }

            // Verifica se encontrou um número menor
            if (numeros[i] < Menor)
            {
                Menor = numeros[i];
            }
        }

        // Exibe o resultado
        Console.WriteLine();
        Console.WriteLine($"O maior número é: {Maior}");
        Console.WriteLine($"O menor número é: {Menor}");
    }
}