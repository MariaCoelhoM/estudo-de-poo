/*
O banco Uati comprou diversos caixas eletrônicos, mas por terem pego a opção mais
barata nas Casas Bahia, eles vieram sem sistema operacional.
Faça um programa que possa ser instalado nesses caixas eletrônicos. Para acessar um
caixa eletrônico, um usuário deve ter um login e senha no sistema. Após logado, um usuário
pode realizar um depósito, um saque, visualizar seu saldo ou visualizar seu extrato.
Um usuário só pode realizar um saque se tiver dinheiro o suficiente em sua conta. Para
cada operação realizada pelo usuário, deve ser registrado em seu extrato. Se solicitado o
extrato do usuário, deve ser impresso o histórico de operações do usuário.*/
using System;

class Caixa
{
    // Atributos
    public string Login;
    public string Senha;
    public double Saldo;

    // Método para realizar depósito
    public void Deposito()
    {
        Console.Write("Digite o valor do depósito: ");
        double valor = double.Parse(Console.ReadLine());

        Saldo += valor;

        Console.WriteLine("Depósito realizado com sucesso!");
    }

    // Método para realizar saque
    public void Saque()
    {
        Console.Write("Digite o valor do saque: ");
        double valor = double.Parse(Console.ReadLine());

        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }

    // Método para visualizar saldo
    public void VisualizarSaldo()
    {
        Console.WriteLine($"Seu saldo atual é: R$ {Saldo}");
    }

    // Método para visualizar extrato
    public void VisualizarExtrato()
    {
        Console.WriteLine("========== EXTRATO ==========");
        Console.WriteLine($"Saldo atual: R$ {Saldo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Caixa
        Caixa caixa = new Caixa();

        Console.Write("Crie um login: ");
        caixa.Login = Console.ReadLine();

        Console.Write("Crie uma senha: ");
        caixa.Senha = Console.ReadLine();

        int opcao;

        do
        {
            Console.WriteLine();
            Console.WriteLine("====== CAIXA ELETRÔNICO ======");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Visualizar Saldo");
            Console.WriteLine("4 - Visualizar Extrato");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                caixa.Deposito();
            }
            else if (opcao == 2)
            {
                caixa.Saque();
            }
            else if (opcao == 3)
            {
                caixa.VisualizarSaldo();
            }
            else if (opcao == 4)
            {
                caixa.VisualizarExtrato();
            }
            else if (opcao == 5)
            {
                Console.WriteLine("Obrigado por utilizar o caixa eletrônico!");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

        } while (opcao != 5);
    }
}