using System;

class Pessoa
{
    // Atributos
    public string Nome;
    public int Idade;

    // Método
    public void Apresentar()
    {
        Console.WriteLine("Olá! Meu nome é " + Nome + ".");
        Console.WriteLine("Tenho " + Idade + " anos.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Pessoa pessoa = new Pessoa();

        Console.Write("Digite seu nome: ");
        pessoa.Nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        pessoa.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        pessoa.Apresentar();
    }
}