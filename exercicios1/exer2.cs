/*
A faculdade Canses ainda utiliza papel e caneta para realizar o cálculo do aluno matriculado
em uma disciplina, e lhe contratou para criar um programa que automatize isso. Porém,
cada disciplina possui uma nota diferente para aprovação. Enquanto em Algoritmos o aluno
só precisa da nota 5 para ser aprovado, em Cálculo, o aluno precisa da nota 7.
Crie um programa onde seja possível cadastrar alunos em uma disciplina. Deve ser
possível realizar a média da disciplina, e checar se um aluno está aprovado ou não em uma
determinada disciplina. Garanta que seja possível imprimir uma relação dos nomes dos
alunos, suas notas na disciplina e se ele está aprovado ou não.*/
using System;
class Matriculado
{
    // Atributos
    public string Nome;
    public string Materia;
    public int Nota1;
    public int Nota2;
    public double Total;

    // Método
    public void Cadastrar()
    {
        Total = (Nota1 + Nota2) / 2.0;
        if (Materia == "Algoritmos")
        {
            if (Total >= 5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
       else if (Materia == "Calculo")
        {
            if (Total >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}

class Program : Matriculado
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Matriculado matriculado = new Matriculado();

        Console.WriteLine("Digite seu nome: ");
        matriculado.Nome = Console.ReadLine();

        Console.WriteLine("Digite sua Materia: ");
        matriculado.Materia = Console.ReadLine();

        Console.WriteLine("Digite aqui a sua Nota 1: ");
        matriculado.Nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite aqui a sua Nota 2: ");
        matriculado.Nota2 = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("----------Relatorio:------------");
        Console.WriteLine($"Aluno: {matriculado.Nome}");
        Console.WriteLine($"Materia: {matriculado.Materia}");
        Console.WriteLine($"Nota da primeria prova: {matriculado.Nota1}");
        Console.WriteLine($"Nota da segunda prova: {matriculado.Nota2}");
        Console.WriteLine($"Média: {matriculado.Total}");
        matriculado.Cadastrar();
    }
}