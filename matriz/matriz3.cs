using System;

class Program
{
    static void Main()
    {
        int[,] numeros = new int[3, 4];
        int Media = 0;
        double Resultado = 0;

        for (int i = 0; i < numeros.GetLength(0); i++)
        {
            for (int j = 0; j < numeros.GetLength(1); j++)
            {
                Console.Write($"Digite a {i + 1}º nota: ");
                numeros[i,j] = int.Parse(Console.ReadLine());
                Media += numeros[i, j];
            } 
                Resultado = Media / 4;
                Console.Write($"\nO maior numero da matriz é: {Resultado}");
        }
    }
}