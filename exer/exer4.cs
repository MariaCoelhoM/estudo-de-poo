using System;

class Aluno
{
    // Atributos
    public string Nome;
    public string Curso;
    public int Semestre;

    // Método
    public void ApresentarAluno()
    {
        Console.WriteLine($"Aluno:  {Nome}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Semestre: {Semestre}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Aluno aluno = new Aluno();

        Console.Write("Digite aqui o Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Digite aqui o Curso: ");
        aluno.Curso = Console.ReadLine();

        Console.Write("Digite aqui o Semestre: ");
        aluno.Semestre = int.Parse(Console.ReadLine());

        Console.WriteLine();
        aluno.ApresentarAluno();
    }
}