/*
Faça um programa de uma agenda telefônica. Uma agenda telefônica deve possuir
contatos, onde cada contato possui nome, email e telefone. Após cadastrado, deve ser
possível alterar os dados cadastrais de um contato.
Deve ser possível realizar um cadastro de um novo contato em uma agenda telefônica,
remover um contato, ou buscar um contato por nome ou por email, devolvendo seu telefone.*/
using System;
class Contato
{
    // Atributos
    public string Nome;
    public string Email;
    public int Telefone;

    // Método
    public void AlterarNome(string novoNome)
    {
        Nome = novoNome;
    }
    public void AlterarEmail(string novoEmail)
    {
        Email = novoEmail;
    }
     public void AlterarTelefone(int novoTelefone)
    {
        Telefone = novoTelefone;
    }
}

class Program : Contato
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Contato contato = new Contato();

        Console.WriteLine("Digite seu nome: ");
        contato.Nome = Console.ReadLine();

        Console.WriteLine("Digite seu cpf: ");
        contato.Email = Console.ReadLine();

        Console.WriteLine("Digite aqui o seu salario: ");
        contato.Telefone = int.Parse(Console.ReadLine());

        Console.WriteLine("O que deseja alterar?");
        Console.WriteLine("1 - Nome");
        Console.WriteLine("2 - Email");
        Console.WriteLine("3 - Telefone");
        Console.WriteLine("4 - Nada");

        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Console.Write("Novo nome: ");
            contato.AlterarNome(Console.ReadLine());
        }
        else if (opcao == 2)
        {
            Console.Write("Novo email: ");
            contato.AlterarEmail(Console.ReadLine());
        }
        else if (opcao == 3)
        {
            Console.Write("Novo telefone: ");
            contato.AlterarTelefone(int.Parse(Console.ReadLine()));
        }
        else if (opcao == 4)
        {
            Console.Write("Você preferiu não alterar nada!");
        }

        Console.WriteLine();
        Console.WriteLine("----------Telefonica:------------");
        Console.WriteLine($"Nome: {contato.Nome}");
        Console.WriteLine($"Seu Email: {contato.Email}");
        Console.WriteLine($"Seu Telefone: R${contato.Telefone}");
    }
}