using System;
using System.Collections.Generic;

class Pessoa
{
    // Atributos
    public string Nome;
    public int Idade;
}

class Program
{
    static void Main(string[] args)
    {
        // Lista que guarda objetos Pessoa
        List<Pessoa> pessoas = new List<Pessoa>();

        // Criando uma pessoa
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Maria";
        pessoa1.Idade = 20;

        Pessoa pessoa2 = new Pessoa();
        pessoa2.Nome = "Eliana";
        pessoa2.Idade = 44;

        Pessoa pessoa3 = new Pessoa();
        pessoa3.Nome = "Rogerio";
        pessoa3.Idade = 51;

        // Adicionando objetos na lista
        pessoas.Add(pessoa1);
        pessoas.Add(pessoa2);
        pessoas.Add(pessoa3);

        int valor = 0;
        
        while (valor != 3)
        {
        Console.WriteLine("1-Deseja retirar um nome?");
        Console.WriteLine("2-Deseja retirar uma idade?");
        Console.WriteLine("3-Sair");
        
        valor = int.Parse(Console.ReadLine());

        if (valor == 1)
        {
            Console.Write("Digite o nome para remover: ");
            string nomeProcurado = Console.ReadLine();

            bool encontrado = false;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == nomeProcurado)
                {
                    pessoas.Remove(pessoa);
                    Console.WriteLine("Pessoa removida!");

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Nome não encontrado.");
            }
        }
        else if (valor == 2)
        {
            Console.Write("Digite uma idade para remover: ");
            int idadeProcurada = int.Parse(Console.ReadLine());

            bool encontrado = false;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Idade == idadeProcurada)
                {
                    pessoas.Remove(pessoa);
                    Console.WriteLine("Pessoa removida!");

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Idade não encontrado.");
            }
        }
        }
        // Percorrendo a lista
        foreach(Pessoa pessoa in pessoas)
        {
            Console.WriteLine(pessoa.Nome + "-" + pessoa.Idade);
        }
    }
}