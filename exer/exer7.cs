using System;

class Filme 
{
    // Atributos
    public string Titulo;
    public string Diretor;
    public int AnoLancamento;
    public string Genero;

    // Método
    public void ExibirFilme()
    {
        Console.WriteLine($"Filme:  {Titulo}");
        Console.WriteLine($"Diretor: {Diretor}");
        Console.WriteLine($"Ano: {AnoLancamento}");
        Console.WriteLine($"Gênero: {Genero}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Filme filme = new Filme();

        Console.Write("Digite aqui o Titulo: ");
        filme.Titulo = Console.ReadLine();

        Console.Write("Digite aqui o Diretor: ");
        filme.Diretor = Console.ReadLine();

        Console.Write("Digite aqui o Ano de Lançamento: ");
        filme.AnoLancamento = int.Parse(Console.ReadLine());

        Console.Write("Digite aqui o Genero: ");
        filme.Genero = Console.ReadLine();

        Console.WriteLine();
        filme.ExibirFilme();
    }
}