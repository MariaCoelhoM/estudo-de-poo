/*A Receita Federal está te procurando. Mas calma: é para ajudá-los a resolver um problema.
Eles precisam de um programa que os ajude a calcular as taxas de produtos que são
aprendidos. Um produto possui nome, valor e imposto. Porém, existem dois tipos de
produtos:
- nacional: possui um imposto de 5%
- internacional: possui um imposto de 10%
Cada pessoa que foi parada pela Receita Federal possui uma lista de produtos
apreendidos. A Receita Federal deseja que você gere um relatório apresentando todos os
produtos apreendidos por aquela pessoa, e a taxa total, em R$, a ser paga.*/
using System;
using System.Collections.Generic; //importante lembrar as bibliotecas!!

// Classe que representa um produto
class Produto
{
    // Atributos
    public string Nome;
    public double Valor;
    public string Tipo; // Nacional ou Internacional
    public double Imposto;

    // Método para calcular o imposto
    public void CalcularImposto()
    {
        if (Tipo.ToLower() == "nacional") //converte todos os caracteres de uma string para letras minúsculas
        {
            Imposto = Valor * 0.05;
        }
        else if (Tipo.ToLower() == "internacional")
        {
            Imposto = Valor * 0.10;
        }
        else
        {
            Console.WriteLine("Tipo de produto inválido!");
            Imposto = 0;
        }
    }
}

// Classe que representa uma pessoa parada pela Receita Federal
class Pessoa
{
    // Atributos
    public string Nome;

    // Lista de produtos apreendidos
    public List<Produto> Produtos = new List<Produto>();

    // Método para imprimir o relatório
    public void Relatorio()
    {
        double totalImpostos = 0;

        Console.WriteLine();
        Console.WriteLine("========== RELATÓRIO ==========");
        Console.WriteLine($"Pessoa: {Nome}");
        Console.WriteLine();

        foreach (Produto produto in Produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Valor: R$ {produto.Valor:F2}");
            Console.WriteLine($"Tipo: {produto.Tipo}");
            Console.WriteLine($"Imposto: R$ {produto.Imposto:F2}");
            Console.WriteLine("---------------------------");

            totalImpostos += produto.Imposto;
        }

        Console.WriteLine($"Total de impostos: R$ {totalImpostos:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Cria uma pessoa
        Pessoa pessoa = new Pessoa();

        Console.Write("Digite o nome da pessoa: ");
        pessoa.Nome = Console.ReadLine();

        Console.Write("Quantos produtos foram apreendidos? ");
        int quantidade = int.Parse(Console.ReadLine());

        // Cadastro dos produtos
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Produto {i + 1}");

            Produto produto = new Produto();

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Valor: ");
            produto.Valor = double.Parse(Console.ReadLine());

            Console.Write("Tipo (Nacional ou Internacional): ");
            produto.Tipo = Console.ReadLine();

            // Calcula o imposto
            produto.CalcularImposto();

            // Adiciona o produto na lista da pessoa
            pessoa.Produtos.Add(produto);
        }

        // Imprime o relatório
        pessoa.Relatorio();
    }
}