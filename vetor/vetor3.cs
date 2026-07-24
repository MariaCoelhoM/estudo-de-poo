using System;
class Program
{
    static void Main()
    {
        // Cria um vetor com 6 posições
        int[] numeros = new int[10];
        int resultado = 0;
        //double Media = 0;

        // Lê os 6 números usamos o numeros.Length.
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º numero: ");
            numeros[i] = int.Parse(Console.ReadLine());
            
            if (numeros[i] % 2 == 0)
            {
                Console.WriteLine("Esse numero e par!");
                resultado += 1;
            }
            else
            {
                Console.WriteLine("Esse numero não e par!");
            }
        }

        // Exibe a média
        Console.WriteLine();
        Console.WriteLine($"A Quantidade de pares é: {resultado}");

    }
}