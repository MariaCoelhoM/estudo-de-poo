/*• Implemente um software que simula um sistema de uma Biblioteca
• Crie uma classe Livro que contém informações de título, autor e ano de
publicação
• Crie uma classe Biblioteca que contém 0, 1 ou mais livros
• Na classe Biblioteca, deve ser possível alugar 1 livro, devolver 1 livro ou
imprimir a lista de livros, incluindo o título, autor e ano de publicação*/
using System;
using System.Collections.Generic;

// Classe que representa um livro
class Livro
{
    // Atributos do livro
    public string Titulo;
    public string Autor;
    public int AnoPublicacao;

    // Construtor: usado para criar um livro já preenchido
    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = ano;
    }
}

// Classe que representa a biblioteca
class Biblioteca
{
    // Lista que armazena os livros da biblioteca
    private List<Livro> livros = new List<Livro>();

    // Método para adicionar (devolver) um livro à biblioteca
    public void DevolverLivro(Livro livro)
    {
        livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' devolvido com sucesso!");
    }

    // Método para alugar (remover) um livro da biblioteca
    public void AlugarLivro(string titulo)
    {
        // Procura um livro com o título informado
        Livro encontrado = null;

        foreach (Livro livro in livros)
        {
            //É um método da classe string que converte todas as letras de um texto para minúsculas.
            if (livro.Titulo.ToLower() == titulo.ToLower())
            {
                encontrado = livro;
                break;
            }
        }

        // Se encontrou, remove da lista
        if (encontrado != null)
        {
            livros.Remove(encontrado);
            Console.WriteLine($"Livro '{encontrado.Titulo}' alugado com sucesso!");
        }
        else
        {
            Console.WriteLine("Livro não encontrado na biblioteca.");
        }
    }

    // Método para imprimir todos os livros
    public void ListarLivros()
    {
        Console.WriteLine("\n===== LIVROS DISPONÍVEIS =====");

        // Verifica se a biblioteca está vazia
        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro disponível.");
            return;
        }

        // Percorre todos os livros da lista
        foreach (Livro livro in livros)
        {
            Console.WriteLine($"Título: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine($"Ano: {livro.AnoPublicacao}");
            Console.WriteLine("----------------------");
        }
    }
}

class Program
{
    static void Main()
    {
        // Cria uma biblioteca
        Biblioteca biblioteca = new Biblioteca();

        // Adiciona alguns livros iniciais
        biblioteca.DevolverLivro(new Livro("Dom Casmurro", "Machado de Assis", 1899));
        biblioteca.DevolverLivro(new Livro("O Hobbit", "J.R.R. Tolkien", 1937));
        biblioteca.DevolverLivro(new Livro("1984", "George Orwell", 1949));

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU BIBLIOTECA =====");
            Console.WriteLine("1 - Alugar livro");
            Console.WriteLine("2 - Devolver livro");
            Console.WriteLine("3 - Listar livros");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Console.Write("Digite o título do livro: ");
                    string tituloAlugar = Console.ReadLine();

                    biblioteca.AlugarLivro(tituloAlugar);

                    break;

                case 2:

                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();

                    Console.Write("Ano de publicação: ");
                    int ano = int.Parse(Console.ReadLine());

                    // Cria um novo livro e adiciona à biblioteca
                    Livro novoLivro = new Livro(titulo, autor, ano);

                    biblioteca.DevolverLivro(novoLivro);

                    break;

                case 3:

                    biblioteca.ListarLivros();

                    break;

                case 0:

                    Console.WriteLine("Programa encerrado.");

                    break;

                default:

                    Console.WriteLine("Opção inválida.");

                    break;
            }

        } while (opcao != 0);
    }
}