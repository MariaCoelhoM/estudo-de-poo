/*Um supermercado está te procurando para desenvolver um sistema para os caixas do
estabelecimento.
O sistema deve poder cadastrar produtos no estoque do supermercado. Um produto possui
nome e preço. Um produto também pode estar com uma porcentagem de desconto,
calculado na hora em que for finalizado a compra.
Uma pessoa pode fazer uma compra com quantos produtos quiser. Porém, uma pessoa só
pode adicionar um item ao seu carrinho se este produto estiver no estoque. Ao adicionar um
item ao carrinho, este item deve ser removido do estoque. Da mesma forma, se uma
pessoa tirar um produto do carrinho, este deve ser devolvido ao estoque.
Ao finalizar a compra, deve ser calculado o preço total da compra, imprimindo o recibo do
cliente com a lista dos produtos comprados e seus respectivos preços, e o preço total da
compra. Produtos em desconto devem ter seu descontos abatidos na hora da compra.*/
using System;
using System.Collections.Generic;

// Classe que representa um produto do supermercado
class Produto
{
    // Atributos
    public string Nome;
    public double Preco;
    public double Desconto; // porcentagem (0, 10, 20...)

    // Método que calcula o preço final do produto
    public double PrecoFinal()
    {
        return Preco - (Preco * Desconto / 100);
    }
}

// Classe que representa um cliente
class Cliente
{
    // Atributos
    public string Nome;

    // Carrinho de compras
    public List<Produto> Carrinho = new List<Produto>();

    // Método que imprime o recibo
    public void Recibo()
    {
        double total = 0;

        Console.WriteLine();
        Console.WriteLine("========== RECIBO ==========");
        Console.WriteLine($"Cliente: {Nome}");
        Console.WriteLine();

        foreach (Produto produto in Carrinho)
        {
            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Preço original: R$ {produto.Preco:F2}");
            Console.WriteLine($"Desconto: {produto.Desconto}%");
            Console.WriteLine($"Preço final: R$ {produto.PrecoFinal():F2}");
            Console.WriteLine("-------------------------");

            total += produto.PrecoFinal();
        }

        Console.WriteLine($"TOTAL DA COMPRA: R$ {total:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Estoque do supermercado
        List<Produto> estoque = new List<Produto>();

        // Cadastro de alguns produtos
        estoque.Add(new Produto
        {
            Nome = "Arroz",
            Preco = 25,
            Desconto = 0
        });

        estoque.Add(new Produto
        {
            Nome = "Feijão",
            Preco = 12,
            Desconto = 10
        });

        estoque.Add(new Produto
        {
            Nome = "Leite",
            Preco = 7,
            Desconto = 0
        });

        estoque.Add(new Produto
        {
            Nome = "Café",
            Preco = 18,
            Desconto = 15
        });

        // Cria o cliente
        Cliente cliente = new Cliente();

        Console.Write("Digite o nome do cliente: ");
        cliente.Nome = Console.ReadLine();

        int opcao;

        do
        {
            Console.WriteLine();
            Console.WriteLine("======= SUPERMERCADO =======");
            Console.WriteLine("1 - Mostrar estoque");
            Console.WriteLine("2 - Adicionar produto ao carrinho");
            Console.WriteLine("3 - Remover produto do carrinho");
            Console.WriteLine("4 - Mostrar carrinho");
            Console.WriteLine("5 - Finalizar compra");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine();
                Console.WriteLine("=== ESTOQUE ===");

                foreach (Produto produto in estoque)
                {
                    Console.WriteLine(produto.Nome);
                }
            }

            else if (opcao == 2)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                bool encontrado = false;

                foreach (Produto produto in estoque)
                {
                    if (produto.Nome.ToLower() == nome.ToLower())
                    {
                        cliente.Carrinho.Add(produto);
                        estoque.Remove(produto);

                        Console.WriteLine("Produto adicionado ao carrinho.");

                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Produto não encontrado no estoque.");
                }
            }

            else if (opcao == 3)
            {
                Console.Write("Digite o nome do produto para remover: ");
                string nome = Console.ReadLine();

                bool encontrado = false;

                foreach (Produto produto in cliente.Carrinho)
                {
                    if (produto.Nome.ToLower() == nome.ToLower())
                    {
                        estoque.Add(produto);
                        cliente.Carrinho.Remove(produto);

                        Console.WriteLine("Produto removido do carrinho.");

                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Produto não está no carrinho.");
                }
            }

            else if (opcao == 4)
            {
                Console.WriteLine();
                Console.WriteLine("=== CARRINHO ===");

                if (cliente.Carrinho.Count == 0)
                {
                    Console.WriteLine("Carrinho vazio.");
                }
                else
                {
                    foreach (Produto produto in cliente.Carrinho)
                    {
                        Console.WriteLine(produto.Nome);
                    }
                }
            }

            else if (opcao == 5)
            {
                cliente.Recibo();
            }

            else
            {
                Console.WriteLine("Opção inválida.");
            }

        } while (opcao != 5);
    }
}