using System;
using System.Collections.Generic;

class Pessoa
{
    // Atributos
    public string Nome;
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

        Pessoa pessoa2 = new Pessoa();
        pessoa2.Nome = "Eliana";

        Pessoa pessoa3 = new Pessoa();
        pessoa3.Nome = "Rogerio";


        // Adicionando objetos na lista
        pessoas.Add(pessoa1);
        pessoas.Add(pessoa2);
        pessoas.Add(pessoa3);


        // Percorrendo a lista
        foreach(Pessoa pessoa in pessoas)
        {
            Console.WriteLine(pessoa.Nome);
        }
    }
}