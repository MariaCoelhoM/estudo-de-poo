/*
Uma empresa precisa calcular os salários de seus funcionários. Sabe-se que um
funcionário possui um nome, cpf e salário. Um funcionário também tem seu salário líquido,
que se baseia no seu salário, descontando impostos, a partir do valor do salário do
funcionário:
- Até R$ 2000: sem descontos
- De R$ 2000,01 a R$ 3000: 7,5%
- De R$ 3000,01 a R$ 4000: 15%
- De R$ 4000,01 a R$ 5000: 22,5%
- Acima de R$ 5000,01: 27,5%
A empresa quer poder calcular o total do pagamento no mês. No relatório, deve estar
contido o pagamento para cada funcionário, incluindo o salário bruto, a quantidade
descontada, e o salário líquido. No final, deve ser apresentado o total do salário bruto dos
funcionários, o total descontado, e o total do salário líquido.*/
using System;
class Funcionario
{
    // Atributos
    public string Nome;
    public int Cpf;
    public double Salario;
    public double Total;

    // Método
    public void Relatorio()
    {
        if(Salario <= 2000)
        {
            Console.WriteLine("Sem desconto!");
            Total = Salario;
        }
        else if(Salario >= 2000.01 && Salario <= 3000)
        {
            Console.WriteLine("Seu desconto é de 7,5%");
            Total = Salario - (Salario * 0.075);
        }
        else if(Salario >= 3000.01 && Salario <= 4000)
        {
            Console.WriteLine("Seu desconto é de 15%");
            Total = Salario - (Salario * 0.15);
        }
         else if(Salario >= 4000.01 && Salario <= 5000)
        {
            Console.WriteLine("Seu desconto é de 22,5%");
            Total = Salario - (Salario * 0.225);
        }
        else if(Salario >= 5000.01)
        {
            Console.WriteLine("Seu desconto é de 27,5%");
            Total = Salario - (Salario * 0.275);
        }
    }
}

class Program : Funcionario
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Funcionario funcionario = new Funcionario();

        Console.WriteLine("Digite seu nome: ");
        funcionario.Nome = Console.ReadLine();

        Console.WriteLine("Digite seu cpf: ");
        funcionario.Cpf = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite aqui o seu salario: ");
        funcionario.Salario = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("----------Relatorio:------------");
        Console.WriteLine($"Funcionário: {funcionario.Nome}");
        Console.WriteLine($"CPF: {funcionario.Cpf}");
        Console.WriteLine($"Salário bruto: R${funcionario.Salario}");
        Console.WriteLine($"Salário líquido: R${funcionario.Total}");
        funcionario.Relatorio();
    }
}