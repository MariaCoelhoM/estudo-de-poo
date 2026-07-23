using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    { 
        List<string> nomes = new List<string>();
        int valor = 0;
        
        while (valor != 4)
        {
        Console.WriteLine("1-Deseja cadastrar nomes?");
        Console.WriteLine("2-Deseja tirar nomes?");
        Console.WriteLine("3-Deseja procurar um nome?");
        Console.WriteLine("4-Sair");
        
        valor = int.Parse(Console.ReadLine());

        if(valor == 1)
        {
        Console.Write("Quantos nomes deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        for(int i = 1; i <= quantidade; i++)
        {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();
            nomes.Add(nome);
        }
        }
        else if(valor == 2)
        {
        Console.Write("Quantos nomes deseja tirar? ");
        int quantidade = int.Parse(Console.ReadLine());

        for(int i = 1; i <= quantidade; i++)
        {
            Console.Write("Qual o nome? ");
            string nome = Console.ReadLine();
            nomes.Remove(nome);
        }
        }
        else if(valor == 3)
        {
        Console.Write("Digite o nome que deseja procurar: ");
        string nomeProcurado = Console.ReadLine();

        bool encontrado = false;

        foreach (string nome in nomes)
        {
            if (nome == nomeProcurado)
            {
                Console.WriteLine($"O nome {nome} foi encontrado!");
                encontrado = true;
                break; // Para de procurar, porque já encontrou
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Nome não encontrado.");
        }
        }
        }
        foreach(string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        Console.WriteLine($"A quantidade de nomes foram:{nomes.Count}");
    }
}