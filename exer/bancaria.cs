using System;

class ContaBancaria
{
    //atributos
    public double Saldo;
    public string Titular;

    public void Depositar(double valor)
    {
        Saldo = Saldo + valor;
    }
       
    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo = Saldo - valor; // Ou simplesmente: Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para este saque!");
        }
    } 
        
    public void MostrarSaldo()
    {
        Console.WriteLine($"O saldo atual de {Titular} é: R$ {Saldo}");
    }
        

}
class Program
{
     static void Main(string[] args)
    {
        
        ContaBancaria conta = new ContaBancaria();

        Console.Write("Nome do titular: ");
        conta.Titular = Console.ReadLine();

        Console.Write("Saldo inicial: ");
        conta.Saldo = double.Parse(Console.ReadLine());

        Console.Write("Valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine());
        conta.Depositar(deposito);

        Console.Write("Valor para saque: ");
        double saque = double.Parse(Console.ReadLine());
        conta.Sacar(saque);

        Console.WriteLine();
        conta.MostrarSaldo();

    }
}
