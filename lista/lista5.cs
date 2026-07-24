using System;
using System.Collections.Generic;

class Produto
{
    // Atributos
    public string Nome;
    public double Preco;
}

class Program
{
    static void Main(string[] args)
    {
        // Lista que guarda objetos Pessoa
        List<Produto> produtos = new List<Produto>();

        // Criando uma pessoa
        Produto produto1 = new Produto();
        produto1.Nome = "Arroz";
        produto1.Preco = 10.50;

        Produto produto2 = new Produto();
        produto2.Nome = "Feijao";
        produto2.Preco = 8.00;

        Produto produto3 = new Produto();
        produto3.Nome = "Batata";
        produto3.Preco = 6.99;

        Produto produto4 = new Produto();
        produto4.Nome = "Cafe";
        produto4.Preco = 3.99;

        // Adicionando objetos na lista
        produtos.Add(produto1);
        produtos.Add(produto2);
        produtos.Add(produto3);
        produtos.Add(produto4);

        int valor = 0;
        
        while (valor != 5)
        {
        Console.WriteLine("1-Adicionar produto");
        Console.WriteLine("2-Mostrar produtos");
        Console.WriteLine("3-Remover produto");
        Console.WriteLine("4-Procurar produto");
        Console.WriteLine("5-Sair");
        
        valor = int.Parse(Console.ReadLine());

        if (valor == 1)
        {
            Produto novoProduto = new Produto();

            Console.Write("Nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            novoProduto.Preco = double.Parse(Console.ReadLine());

            produtos.Add(novoProduto);
        }
        else if (valor == 2)
        {
        // Percorrendo a lista
        foreach(Produto produto in produtos)
        {
            Console.WriteLine(produto.Nome + "-" + produto.Preco);
        }
        }
        else if (valor == 3)
        {
                Console.Write("Digite o nome do produto para remover: ");
                string nomeProcurado = Console.ReadLine();

                Produto produtoRemover = null;

                foreach (Produto produto in produtos)
                {
                    if (produto.Nome == nomeProcurado)
                    {
                        produtoRemover = produto;
                        break;
                    }
                }

            if (produtoRemover != null)
            {
                produtos.Remove(produtoRemover);
                Console.WriteLine("Produto removido!");
            }
        }
        else if (valor == 4)
        {
            Console.Write("Digite o nome do produto: ");
            string nomeProcurado = Console.ReadLine();
            bool encontrado = false;

            foreach (Produto produto in produtos)
            {
                if (produto.Nome == nomeProcurado)
                {
                    Console.WriteLine($"Produto: {produto.Nome}");
                    Console.WriteLine($"Preço: R${produto.Preco}");

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Nome não encontrado.");
            }
        }
    }
}
}