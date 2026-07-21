/*• Crie uma classe Funcionario, que possui nome e salario, e possui um método chamado para receber
aumento anual.
• Crie a classe FuncionarioTrabalhador, que herda de Funcionario, recebe um aumento anual de 10% e pode
Trabalhar;
• Crie a classe Programador, que herda de FuncionarioTrabalhador, e ao Trabalhar, imprime
“programando”;
• Crie a classe Designer, que herda de FuncionarioTrabalhador, e ao Trabalhar, imprime “criando arte”;
• Crie a classe Gerente, que herda de Funcionario, e tem um aumento anual de 20%
• Crie a classe Empresa, que possui uma lista de Funcionario, e pode dar aumento anual para todos, listar
os funcionarios e fazer todos os funcionarios trabalharem. Ao listar funcionarios, deve ser impresso nome
e salario atual. Somente o FuncionarioTrabalhador pode trabalhar.*/
using System;
using System.Collections.Generic;

// Classe Funcionario
// Classe base (pai)
class Funcionario
{

    // Atributos protegidos
    // As classes filhas poderão acessar
    protected string nome;
    protected double salario;

    // Construtor
    public Funcionario(string nome, double salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    // Método virtual para aumento anual
    //
    // Pode ser sobrescrito pelas classes filhas
    public virtual void AumentoAnual()
    {
        // Aumento padrão de 5%

        salario += salario * 0.05;
    }

    // Método para mostrar informações
    public void MostrarFuncionario()
    {
        Console.WriteLine(
            $"Nome: {nome} | Salário: R$ {salario:F2}"
        );
    }

    // Retorna o salário atual
    public double GetSalario()
    {
        return salario;
    }

}

// Classe FuncionarioTrabalhador
// Herda de Funcionario
class FuncionarioTrabalhador : Funcionario
{
    // Construtor
    public FuncionarioTrabalhador(string nome, double salario)
        : base(nome, salario)
    {

    }

    // Sobrescrevendo aumento anual
    //
    // Trabalhadores recebem 10%
    public override void AumentoAnual()
    {
        salario += salario * 0.10;
    }

    // Método Trabalhar
    //
    // Somente funcionários trabalhadores
    // possuem esse método
    public virtual void Trabalhar()
    {
        Console.WriteLine($"{nome} está trabalhando.");
    }

}

// Classe Programador
// Herda de FuncionarioTrabalhador

class Programador : FuncionarioTrabalhador
{
    // Construtor
    public Programador(string nome, double salario)
        : base(nome, salario)
    {

    }

    // Sobrescrevendo o método Trabalhar
    public override void Trabalhar()
    {
        Console.WriteLine($"{nome} está programando.");
    }

}

// Classe Designer
// Herda de FuncionarioTrabalhador
class Designer : FuncionarioTrabalhador
{

    // Construtor
    public Designer(string nome, double salario)
        : base(nome, salario)
    {

    }

    // Sobrescrevendo o método Trabalhar
    public override void Trabalhar()
    {
        Console.WriteLine($"{nome} está criando arte.");
    }

}

// Classe Gerente
// Herda de Funcionario
class Gerente : Funcionario
{
    // Construtor
    public Gerente(string nome, double salario)
        : base(nome, salario)
    {

    }

    // Sobrescrevendo aumento anual
    //
    // Gerentes recebem 20%
    public override void AumentoAnual()
    {
        salario += salario * 0.20;
    }

}

// Classe Empresa
// Possui uma lista de funcionários
class Empresa
{
    // Lista que guarda todos os funcionários
    private List<Funcionario> funcionarios;

    // Construtor
    public Empresa()
    {
        funcionarios = new List<Funcionario>();
    }

    // Adiciona funcionário na empresa
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    // Dá aumento para todos funcionários
    public void DarAumentoAnual()
    {

        foreach(Funcionario funcionario in funcionarios)
        {
            funcionario.AumentoAnual();
        }

    }

    // Lista todos os funcionários

    public void ListarFuncionarios()
    {

        Console.WriteLine("\n===== FUNCIONÁRIOS =====");

        foreach(Funcionario funcionario in funcionarios)
        {
            funcionario.MostrarFuncionario();
        }

    }

    // Faz todos os funcionários trabalharem
    //
    // Porém somente quem é
    // FuncionarioTrabalhador pode trabalhar

    public void FazerTodosTrabalharem()
    {

        Console.WriteLine("\n===== TRABALHO =====");

        foreach(Funcionario funcionario in funcionarios)
        {
            // Verifica se o funcionário
            // pertence à classe trabalhadora
            if(funcionario is FuncionarioTrabalhador trabalhador)
            {

                trabalhador.Trabalhar();

            }
            else
            {
                Console.WriteLine( $"{funcionario.GetType().Name} não trabalha diretamente.");
            }

        }

    }

}

// Programa principal
class Program
{

    static void Main()
    {
        // Criando uma empresa
        Empresa empresa = new Empresa();

        // Criando funcionários
        Programador programador = new Programador(
            "Maria",
            5000
        );

        Designer designer = new Designer(
            "Ana",
            3500
        );

        Gerente gerente = new Gerente(
            "Carlos",
            8000
        );

        // Adicionando funcionários na empresa
        empresa.AdicionarFuncionario(programador);
        empresa.AdicionarFuncionario(designer);
        empresa.AdicionarFuncionario(gerente);

        // Lista inicial
        empresa.ListarFuncionarios();
        // Aplicando aumento anual
        Console.WriteLine("\nAplicando aumento anual...");
        empresa.DarAumentoAnual();
        // Lista depois do aumento
        empresa.ListarFuncionarios();
        // Faz trabalhadores trabalharem
        empresa.FazerTodosTrabalharem();


    }

}