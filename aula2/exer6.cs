//Faça um programa que o usuário digita sua data de nascimento e devolve
//quantos anos, meses, dias, horas e segundos a pessoa possui desde que nasceu.
using System;

class Program
{
    static void Main()
    {
        // Pede para o usuário digitar a data de nascimento
        Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");

        // Lê a data digitada e converte para DateTime
        DateTime nascimento = DateTime.Parse(Console.ReadLine());

        // Pega a data e hora atuais do computador
        DateTime hoje = DateTime.Now;

        // Calcula a diferença entre hoje e a data de nascimento
        TimeSpan diferenca = hoje - nascimento;

        // Cálculo da idade em anos
        // Começa calculando a diferença entre os anos
        int anos = hoje.Year - nascimento.Year;

        // Se a pessoa ainda não fez aniversário este ano,
        // diminui um ano da idade
        if (hoje < nascimento.AddYears(anos))
        {
            anos--;
        }

        // Cálculo dos meses
        // Calcula a diferença entre os meses
        int meses = hoje.Month - nascimento.Month;

        // Se o mês atual for menor que o mês de nascimento,
        // adiciona 12 para corrigir
        if (meses < 0)
        {
            meses += 12;
        }

        // Exibe os resultados

        Console.WriteLine("\n===== RESULTADO =====");

        Console.WriteLine($"Anos: {anos}");
        Console.WriteLine($"Meses: {meses}");

        // Total de dias desde o nascimento
        Console.WriteLine($"Dias: {(int)diferenca.TotalDays}");

        // Total de horas desde o nascimento
        Console.WriteLine($"Horas: {(long)diferenca.TotalHours}");

        // Total de segundos desde o nascimento
        Console.WriteLine($"Segundos: {(long)diferenca.TotalSeconds}");
    }
}