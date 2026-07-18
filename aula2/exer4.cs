//Faça um programa que simula uma lista de tarefas
//O programa deve permitir que o usuário insira uma tarefa ou remova uma tarefa
//O usuário deve poder escrever a tarefa
//O programa também deve poder imprimir a lista de tarefas
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n===== LISTA DE TAREFAS =====");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Remover tarefa");
            Console.WriteLine("3 - Mostrar tarefas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite a tarefa: ");
                string tarefa = Console.ReadLine();

                tarefas.Add(tarefa);

                Console.WriteLine("Tarefa adicionada!");
            }
            else if (opcao == 2)
            {
                Console.Write("Digite a tarefa que deseja remover: ");
                string tarefa = Console.ReadLine();

                if (tarefas.Contains(tarefa))
                {
                    tarefas.Remove(tarefa);
                    Console.WriteLine("Tarefa removida!");
                }
                else
                {
                    Console.WriteLine("Essa tarefa não existe.");
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("\nLista de tarefas:");

                if (tarefas.Count == 0)
                {
                    Console.WriteLine("Nenhuma tarefa cadastrada.");
                }
                else
                {
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {tarefas[i]}");
                    }
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Programa encerrado.");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}