//Faça um programa que simula um caixa de supermercado
//O usuário deve poder adicionar um item e sua quantidade
//Se o item já existir na lista, a nova quantidade deve ser acrescentada a quantidade atual
//Permita imprimir a lista inteira juntamente com a quantidade de elementos da lista
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Um Dictionary funciona como uma "tabela" onde cada chave possui um valor.
        Dictionary<string, int> caixa = new Dictionary<string, int>();

        int opcao;

        do
        {
            Console.WriteLine("\n===== CAIXA DO SUPERMERCADO =====");
            Console.WriteLine("1 - Adicionar item");
            Console.WriteLine("2 - Imprimir lista");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Console.Write("Nome do item: ");
                    string item = Console.ReadLine();

                    Console.Write("Quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    // Verifica se o item já existe
                    // Verifica se uma determinada chave (item) já existe no Dictionary
                    if (caixa.ContainsKey(item))
                    {
                        caixa[item] += quantidade;
                        Console.WriteLine("Quantidade atualizada!");
                    }
                    else
                    {
                        caixa.Add(item, quantidade);
                        Console.WriteLine("Item adicionado!");
                    }

                    break;

                case 2:

                    Console.WriteLine("\n===== LISTA DE COMPRAS =====");

                    foreach (KeyValuePair<string, int> produto in caixa)
                    {
                        Console.WriteLine($"{produto.Key} - {produto.Value}");
                    }

                    Console.WriteLine($"\nQuantidade de itens diferentes: {caixa.Count}");

                    break;

                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);
    }
}

