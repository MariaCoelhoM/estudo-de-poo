/*Uma biblioteca ainda utiliza folha e papel para realizar o cadastro de seus livros, e também
a relação de empréstimo de livros para pessoas, e está procurando você para desenvolver
um software que faça isso de forma mais fácil.
Você deve criar um programa que permita que a biblioteca consulte o acervo de livros
disponíveis para alugar. Um livro possui título, autor e ano de publicação. Para alugar um
livro, uma pessoa deve ter um nome e um cpf.
Uma biblioteca só possui uma certa quantidade de livros. Deve poder existir dois livros
iguais em uma biblioteca. Por exemplo, uma biblioteca pode ter 2 livros de Cálculo do
Stewart e 3 livros de Algoritmos do Cormen.
Deve ser possível adicionar novos livros ao catálogo, ou remover livros do catálogo. Uma
pessoa deve poder alugar um livro, caso ele esteja no catálogo. Ao alugar um livro, deve ser
contabilizado 1 unidade a menos no catálogo.
Uma pessoa só deve poder alugar um livro caso não tenha nenhum livro alugado ainda.*/
using System;
using System.Collections.Generic;

// Classe que representa um livro
class Livro
{
    // Atributos
    public string Titulo;
    public string Autor;
    public int AnoPublicacao;
}

// Classe que representa uma pessoa
class Pessoa
{
    // Atributos
    public string Nome;
    public string CPF;

    // Uma pessoa só pode alugar um livro
    public Livro LivroAlugado = null;

    // Verifica se a pessoa possui livro alugado
    public bool PossuiLivro()
    {
        return LivroAlugado != null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Catálogo da biblioteca
        List<Livro> catalogo = new List<Livro>();

        // Livros cadastrados
        catalogo.Add(new Livro
        {
            Titulo = "Cálculo do Stewart",
            Autor = "James Stewart",
            AnoPublicacao = 2015
        });

        catalogo.Add(new Livro
        {
            Titulo = "Cálculo do Stewart",
            Autor = "James Stewart",
            AnoPublicacao = 2015
        });

        catalogo.Add(new Livro
        {
            Titulo = "Algoritmos do Cormen",
            Autor = "Thomas Cormen",
            AnoPublicacao = 2009
        });

        catalogo.Add(new Livro
        {
            Titulo = "Algoritmos do Cormen",
            Autor = "Thomas Cormen",
            AnoPublicacao = 2009
        });

        catalogo.Add(new Livro
        {
            Titulo = "Algoritmos do Cormen",
            Autor = "Thomas Cormen",
            AnoPublicacao = 2009
        });

        // Cadastro da pessoa
        Pessoa pessoa = new Pessoa();

        Console.Write("Nome: ");
        pessoa.Nome = Console.ReadLine();

        Console.Write("CPF: ");
        pessoa.CPF = Console.ReadLine();

        int opcao;

        do
        {
            Console.WriteLine();
            Console.WriteLine("====== BIBLIOTECA ======");
            Console.WriteLine("1 - Mostrar catálogo");
            Console.WriteLine("2 - Adicionar livro");
            Console.WriteLine("3 - Remover livro");
            Console.WriteLine("4 - Alugar livro");
            Console.WriteLine("5 - Devolver livro");
            Console.WriteLine("6 - Mostrar livro alugado");
            Console.WriteLine("7 - Sair");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            // Mostrar catálogo
            if (opcao == 1)
            {
                Console.WriteLine();
                Console.WriteLine("=== CATÁLOGO ===");

                if (catalogo.Count == 0)
                {
                    Console.WriteLine("Não existem livros.");
                }
                else
                {
                    foreach (Livro livro in catalogo)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine($"Título: {livro.Titulo}");
                        Console.WriteLine($"Autor: {livro.Autor}");
                        Console.WriteLine($"Ano: {livro.AnoPublicacao}");
                    }
                }
            }

            // Adicionar livro
            else if (opcao == 2)
            {
                Livro livro = new Livro();

                Console.Write("Título: ");
                livro.Titulo = Console.ReadLine();

                Console.Write("Autor: ");
                livro.Autor = Console.ReadLine();

                Console.Write("Ano: ");
                livro.AnoPublicacao = int.Parse(Console.ReadLine());

                catalogo.Add(livro);

                Console.WriteLine("Livro adicionado!");
            }

            // Remover livro
            else if (opcao == 3)
            {
                Console.Write("Digite o título: ");
                string titulo = Console.ReadLine();

                bool encontrado = false;

                for (int i = 0; i < catalogo.Count; i++)
                {
                    if (catalogo[i].Titulo.ToLower() == titulo.ToLower())
                    {
                        catalogo.RemoveAt(i);

                        Console.WriteLine("Livro removido.");

                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Livro não encontrado.");
                }
            }

            // Alugar livro
            else if (opcao == 4)
            {
                if (pessoa.PossuiLivro())
                {
                    Console.WriteLine("Você já possui um livro alugado.");
                }
                else
                {
                    Console.Write("Digite o título: ");
                    string titulo = Console.ReadLine();

                    bool encontrado = false;

                    for (int i = 0; i < catalogo.Count; i++)
                    {
                        if (catalogo[i].Titulo.ToLower() == titulo.ToLower())
                        {
                            pessoa.LivroAlugado = catalogo[i];

                            catalogo.RemoveAt(i);

                            Console.WriteLine("Livro alugado com sucesso!");

                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Livro indisponível.");
                    }
                }
            }

            // Devolver livro
            else if (opcao == 5)
            {
                if (!pessoa.PossuiLivro())
                {
                    Console.WriteLine("Você não possui livro alugado.");
                }
                else
                {
                    catalogo.Add(pessoa.LivroAlugado);

                    Console.WriteLine("Livro devolvido!");

                    pessoa.LivroAlugado = null;
                }
            }

            // Mostrar livro alugado
            else if (opcao == 6)
            {
                if (!pessoa.PossuiLivro())
                {
                    Console.WriteLine("Nenhum livro alugado.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("=== LIVRO ALUGADO ===");
                    Console.WriteLine($"Título: {pessoa.LivroAlugado.Titulo}");
                    Console.WriteLine($"Autor: {pessoa.LivroAlugado.Autor}");
                    Console.WriteLine($"Ano: {pessoa.LivroAlugado.AnoPublicacao}");
                }
            }

            else if (opcao == 7)
            {
                Console.WriteLine("Programa encerrado.");
            }

            else
            {
                Console.WriteLine("Opção inválida.");
            }

        } while (opcao != 7);
    }
}