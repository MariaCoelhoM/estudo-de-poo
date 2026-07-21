/*• Crie um software que matricule um aluno em uma aula
• Uma aula pode ter, no máximo, 50 alunos matriculados
• Um aluno deve ter nome e id único
• Uma aula deve ter um professor e uma disciplina
• Um professor possui um nome
• Deve ser possível imprimir a lista de alunos da aula em ordem crescente
• Esta lista deve ter o nome da disciplina, o nome do professor, e a data
atual*/
using System;
using System.Collections.Generic;

// Classe que representa um aluno
class Aluno
{
    // Atributos do aluno
    public int Id;
    public string Nome;
}

// Classe que representa um professor
class Professor
{
    // Nome do professor
    public string Nome;
}

// Classe que representa uma aula
class Aula
{
    // Nome da disciplina
    public string Disciplina;

    // Professor responsável pela aula
    public Professor Professor;

    // Lista de alunos matriculados
    public List<Aluno> Alunos = new List<Aluno>();

    // Método para matricular um aluno
    public void MatricularAluno(Aluno aluno)
    {
        // Verifica se a turma já possui 50 alunos
        if (Alunos.Count >= 50)
        {
            Console.WriteLine("A turma está lotada.");
            return;
        }

        // Verifica se já existe um aluno com o mesmo ID
        foreach (Aluno a in Alunos)
        {
            if (a.Id == aluno.Id)
            {
                Console.WriteLine("Já existe um aluno com esse ID.");
                return;
            }
        }

        // Adiciona o aluno na lista
        Alunos.Add(aluno);

        Console.WriteLine("Aluno matriculado com sucesso!");
    }

    // Método para imprimir a lista de alunos
    public void ImprimirLista()
    {
        // Ordena os alunos pelo nome (ordem crescente)
        Alunos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

        Console.WriteLine("\n===== LISTA DE ALUNOS =====");
        Console.WriteLine($"Disciplina: {Disciplina}");
        Console.WriteLine($"Professor: {Professor.Nome}");
        Console.WriteLine($"Data: {DateTime.Now:dd/MM/yyyy}");

        Console.WriteLine("\nAlunos:");

        foreach (Aluno aluno in Alunos)
        {
            Console.WriteLine($"ID: {aluno.Id} - Nome: {aluno.Nome}");
        }

        Console.WriteLine($"\nTotal de alunos: {Alunos.Count}");
    }
}

class Program
{
    static void Main()
    {
        // Cria o professor
        Professor professor = new Professor();
        professor.Nome = "Carlos Silva";

        // Cria a aula
        Aula aula = new Aula();

        aula.Disciplina = "Programação Orientada a Objetos";
        aula.Professor = professor;

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Matricular aluno");
            Console.WriteLine("2 - Imprimir lista");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    // Cria um novo aluno
                    Aluno aluno = new Aluno();

                    Console.Write("ID: ");
                    aluno.Id = int.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    aluno.Nome = Console.ReadLine();

                    aula.MatricularAluno(aluno);

                    break;

                case 2:

                    aula.ImprimirLista();

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