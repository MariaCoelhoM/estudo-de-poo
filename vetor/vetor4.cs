using System;

class Program
{
    static void Main()
    {
        string[] numeros = new string[5];
        string nome;

        // Lê os 5 nomes
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º nome: ");
            numeros[i] = Console.ReadLine();
        }

        // Pergunta apenas uma vez qual nome deseja procurar
        Console.Write("Digite aqui o nome que você procura: ");
        nome = Console.ReadLine();

        bool encontrado = false;

        // Procura o nome no vetor
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == nome)
            {
                encontrado = true;
            }
        }

        // Mostra o resultado
        if (encontrado)
        {
            Console.WriteLine("Nome encontrado!");
        }
        else
        {
            Console.WriteLine("Nome não encontrado!");
        }
    }
}