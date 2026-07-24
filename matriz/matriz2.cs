using System;

class Program
{
    static void Main()
    {
        int[,] numeros = new int[3, 3];
        int Maior = 0;

        for (int i = 0; i < numeros.GetLength(0); i++)
        {
            for (int j = 0; j < numeros.GetLength(0); j++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i,j] = int.Parse(Console.ReadLine());
                
                if (numeros[i,j] > Maior)
                {
                    Maior = numeros[i,j];
                }
            } 
        }
         Console.WriteLine();
         Console.Write($"O maior numero da matriz é: {Maior}");
    }
}