/*• Implemente o software a partir do diagrama de classes especificado
• Considere que o usuário tem um saldo em sua conta, e dinheiro em sua
carteira
• O usuário não deve poder sacar mais dinheiro do que possui em sua conta, e
não deve poder depositar mais dinheiro do que possui em sua carteira*/
using System;

// Classe que representa uma conta bancária
class ContaBancaria
{
    // Saldo disponível na conta
    public double Saldo;

    // Método para sacar dinheiro
    public bool Sacar(double valor)
    {
        // Verifica se existe saldo suficiente
        if (valor <= Saldo)
        {
            Saldo -= valor;
            return true; // Saque realizado
        }

        return false; // Não foi possível sacar
    }

    // Método para depositar dinheiro
    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}

// Classe que representa o usuário
class Usuario
{
    public string Nome;

    // Dinheiro que o usuário possui na carteira
    public double Carteira;

    // Cada usuário possui uma conta bancária
    public ContaBancaria Conta = new ContaBancaria();

    // Método para sacar dinheiro da conta
    public void Sacar(double valor)
    {
        // Chama o método Sacar da conta
        if (Conta.Sacar(valor))
        {
            // Se conseguiu sacar, o dinheiro vai para a carteira
            Carteira += valor;

            Console.WriteLine("Saque realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente na conta.");
        }
    }

    // Método para depositar dinheiro na conta
    public void Depositar(double valor)
    {
        // Verifica se existe dinheiro suficiente na carteira
        if (valor <= Carteira)
        {
            Carteira -= valor;
            Conta.Depositar(valor);

            Console.WriteLine("Depósito realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Você não possui esse valor na carteira.");
        }
    }

    // Exibe as informações do usuário
    public void MostrarDados()
    {
        Console.WriteLine("\n===== DADOS DO USUÁRIO =====");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Saldo da conta: R$ {Conta.Saldo:F2}");
        Console.WriteLine($"Dinheiro na carteira: R$ {Carteira:F2}");
    }
}

class Program
{
    static void Main()
    {
        // Cria um usuário
        Usuario usuario = new Usuario();

        usuario.Nome = "Maria";

        // Dinheiro inicial
        usuario.Carteira = 100;

        // Saldo inicial da conta
        usuario.Conta.Saldo = 500;

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Mostrar dados");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Console.Write("Valor para depositar: ");
                    double deposito = double.Parse(Console.ReadLine());

                    usuario.Depositar(deposito);

                    break;

                case 2:

                    Console.Write("Valor para sacar: ");
                    double saque = double.Parse(Console.ReadLine());

                    usuario.Sacar(saque);

                    break;

                case 3:

                    usuario.MostrarDados();

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