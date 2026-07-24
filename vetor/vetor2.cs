using System;

class Program
{
    static void Main()
    {
        // Cria um vetor com 6 posições
        int[] numeros = new int[6];
        //double soma = 0;
        double Media = 0;

        // Lê os 6 números usamos o numeros.Length.
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite a sua {i + 1}º nota: ");
            numeros[i] = int.Parse(Console.ReadLine());
            Media += numeros[i];
        }

        double resultado = (double)Media / numeros.Length;

        // Verifica se o aluno foi aprovado ou reprovado
        if (resultado >= 7)
        {
            Console.WriteLine("Você foi aprovado!");
        }
        else
        {
            Console.WriteLine("Você foi reprovado!");
        }

        // Exibe a média
        Console.WriteLine();
        Console.WriteLine($"A sua média foi: {resultado}");

    }
}