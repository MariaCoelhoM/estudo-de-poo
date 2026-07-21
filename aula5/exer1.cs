/*• Crie um programa que possui uma classe Funcionario
• Crie atributos privados para nome, sobrenome e salário mensal
• Crie um método público que imprime o nome, sobrenome e o salário
anual do funcionário
• Crie duas instâncias de Funcionario, com salários diferentes, e chame o
método para impressão de seu salário anual*/
using System;

// Classe Funcionario
class Funcionario
{
    // Atributos privados
    // Só podem ser acessados dentro da classe

    private string nome;
    private string sobrenome;
    private double salarioMensal;

    // Propriedades
    // Permitem acessar os atributos privados

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Sobrenome
    {
        get { return sobrenome; }
        set { sobrenome = value; }
    }

    public double SalarioMensal
    {
        get { return salarioMensal; }
        set { salarioMensal = value; }
    }

    // Método que imprime os dados
    public void ImprimirDados()
    {
        // Calcula o salário anual
        double salarioAnual = SalarioMensal * 12;

        Console.WriteLine("\n===== FUNCIONÁRIO =====");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Sobrenome: {Sobrenome}");
        Console.WriteLine($"Salário Mensal: R$ {SalarioMensal:F2}");
        Console.WriteLine($"Salário Anual: R$ {salarioAnual:F2}");
    }
}

class Program
{
    static void Main()
    {
        // Primeiro funcionário
        Funcionario funcionario1 = new Funcionario();

        funcionario1.Nome = "Maria";
        funcionario1.Sobrenome = "Coelho";
        funcionario1.SalarioMensal = 3500;

        // Segundo funcionário
        Funcionario funcionario2 = new Funcionario();

        funcionario2.Nome = "João";
        funcionario2.Sobrenome = "Silva";
        funcionario2.SalarioMensal = 5200;

        // Imprime os dados
        funcionario1.ImprimirDados();
        funcionario2.ImprimirDados();
    }
}