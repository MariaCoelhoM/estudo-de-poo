using System;

class Produto
{
    // Atributos
    public string Nome;
    public double Preco;
    public int Quantidade;

    // Método
    public void MostrarProduto()
    {
        Console.WriteLine($"Produto:  {Nome}");
        Console.WriteLine($"Preço: {Preco}");
        Console.WriteLine($"Quantidade em estoque: {Quantidade}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Produto produto = new Produto();

        Console.Write("Digite aqui o Nome: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Digite aqui o Preço: ");
        produto.Preco = double.Parse(Console.ReadLine());

        Console.Write("Digite aqui a Quantidade em estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        produto.MostrarProduto();
    }
}