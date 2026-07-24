using System;

class Program
{
    static void Main()
    {
        // Cria um vetor com 8 posições
        int[] numeros = new int[8];

        // Lê os 5 números usamos o numeros.Length.
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}