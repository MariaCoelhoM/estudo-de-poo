/*• Crie uma classe Aluno, com o nome do aluno e sua nota
• Crie uma array com 10 posições, mas crie apenas 9 instâncias de aluno
dentro dela (deixando uma das posições vazias)
• Calcule a média das notas dos alunos. Lembre-se de evitar que seja gerado
um erro ao acessar uma instância nula de aluno*/
using System;

// Classe Aluno
class Aluno
{
    // Atributos do aluno
    public string Nome;
    public double Nota;
}

class Program
{
    static void Main()
    {
        // Cria um vetor com espaço para 10 alunos
        Aluno[] alunos = new Aluno[10];

        // Cria apenas 9 objetos da classe Aluno
        alunos[0] = new Aluno();
        alunos[0].Nome = "Maria";
        alunos[0].Nota = 8.5;

        alunos[1] = new Aluno();
        alunos[1].Nome = "João";
        alunos[1].Nota = 7.0;

        alunos[2] = new Aluno();
        alunos[2].Nome = "Ana";
        alunos[2].Nota = 9.5;

        alunos[3] = new Aluno();
        alunos[3].Nome = "Carlos";
        alunos[3].Nota = 6.0;

        alunos[4] = new Aluno();
        alunos[4].Nome = "Pedro";
        alunos[4].Nota = 8.0;

        alunos[5] = new Aluno();
        alunos[5].Nome = "Julia";
        alunos[5].Nota = 9.0;

        alunos[6] = new Aluno();
        alunos[6].Nome = "Lucas";
        alunos[6].Nota = 7.5;

        alunos[7] = new Aluno();
        alunos[7].Nome = "Fernanda";
        alunos[7].Nota = 10.0;

        alunos[8] = new Aluno();
        alunos[8].Nome = "Bruno";
        alunos[8].Nota = 5.5;

        // A posição alunos[9] permanece vazia (null)
        // Variáveis para calcular a média
        double soma = 0;
        int quantidade = 0;

        Console.WriteLine("===== LISTA DE ALUNOS =====");

        // Percorre todo o vetor
        for (int i = 0; i < alunos.Length; i++)
        {
            // Verifica se existe um objeto nessa posição
            if (alunos[i] != null)
            {
                Console.WriteLine($"{alunos[i].Nome} - Nota: {alunos[i].Nota}");

                soma += alunos[i].Nota;

                quantidade++;
            }
        }

        // Calcula a média apenas dos alunos existentes
        double media = soma / quantidade;
        Console.WriteLine();
        Console.WriteLine($"Média da turma: {media:F2}");
    }
}
