using System;

class Produto
{
    // atributos
    public string Nome;
    public double Preco;
    public double Quantidade;
    //metodos 
    public void AdicionarEstoque(double valor)
    {
        Quantidade += valor;
    }
    public void RemoverEstoque(double valor)
    {
        if (valor <= Quantidade)
        {
            Quantidade -= valor;
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
    }
    public double ValorTotal()
    {
        return Preco * Quantidade;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();
        
        Console.Write("Nome do protudo: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Preço do produto: ");
        produto.Preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade do produto em estoque: ");
        produto.Quantidade = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Quantidade do produto a adicionar em estoque: ");
        double adicionarEstoque = double.Parse(Console.ReadLine());
        produto.AdicionarEstoque(adicionarEstoque);

        Console.Write("Quantidade do produto a remover em estoque: ");
        double removerEstoque = double.Parse(Console.ReadLine());
        produto.RemoverEstoque(removerEstoque);

        Console.WriteLine();
        //produto.ValorTotal();
        Console.WriteLine($"Valor total em estoque: R$ {produto.ValorTotal()}");
    }
    
}