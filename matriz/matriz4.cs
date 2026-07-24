using System;

class Program
{
    static void Main()
    {
        int[,] numeros = new int[4, 4];
        //int Media = 0;
        int Resultado = 0;

        for (int i = 0; i < numeros.GetLength(0); i++)
        {
            for (int j = 0; j < numeros.GetLength(0); j++)
            {
                Console.Write($"Digite a {i + 1}º nota: ");
                numeros[i,j] = int.Parse(Console.ReadLine());
                if(numeros[i,j] % 2 == 0)
                {
                    Resultado +=1;
                }
            } 
        }
        Console.WriteLine($"O numero de valores pares na matriz é:{Resultado}");
    }
}