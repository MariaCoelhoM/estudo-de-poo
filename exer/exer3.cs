using System;

class Livro
{
    // Atributos
    public string Titulo;
    public string Autor;
    public int QuantidadePaginas;

    // Método
    public void MostrarLivro()
    {
        Console.WriteLine($"Título:  {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Quantidade de páginas: {QuantidadePaginas}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Livro livro = new Livro();

        Console.Write("Digite aqui o Titulo: ");
        livro.Titulo = Console.ReadLine();

        Console.Write("Digite aqui o Autor: ");
        livro.Autor = Console.ReadLine();

        Console.Write("Digite aqui a Quantidade de Paginas: ");
        livro.QuantidadePaginas = int.Parse(Console.ReadLine());

        Console.WriteLine();
        livro.MostrarLivro();
    }
}