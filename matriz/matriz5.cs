using System;

class Program
{
    static void Main()
    {
        int[,] numeros = new int[2, 2];
        //int Media = 0;
        //double Resultado = 0;

        for (int i = 0; i < numeros.GetLength(0); i++)
        {
            for (int j = 0; j < numeros.GetLength(1); j++)
            {
                Console.Write($"Digite a {i + 1}º nota: ");
                numeros[i,j] = int.Parse(Console.ReadLine());
            } 
        }
        for (int i = numeros.GetLength(0) - 1; i >= 0; i--)
        {
            for (int j = numeros.GetLength(1) - 1; j >= 0; j--)
            {
                Console.WriteLine(numeros[i,j]);
            }
        }
    }
}