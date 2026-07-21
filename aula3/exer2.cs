//faça 1000 instâncias de carros, e atribua uma cor aleatória
//para cada um (entre vermelho, verde e azul). Depois, exiba a
//quantidade de cada uma das cores.
using System;

// Classe Carro
class Carro
{
    // Atributo que guarda a cor do carro
    public string Cor;
}

class Program
{
    static void Main()
    {
        // Cria um objeto Random para gerar números aleatórios
        Random random = new Random();

        // Cria um vetor para armazenar 1000 objetos da classe Carro
        Carro[] carros = new Carro[1000];

        // Variáveis para contar quantos carros existem de cada cor
        int vermelho = 0;
        int verde = 0;
        int azul = 0;

        // Percorre todas as posições do vetor
        for (int i = 0; i < carros.Length; i++)
        {
            // Cria um novo objeto Carro
            carros[i] = new Carro();

            // Gera um número aleatório entre 0 e 2
            int cor = random.Next(3);

            // Define a cor do carro de acordo com o número sorteado
            if (cor == 0)
            {
                carros[i].Cor = "Vermelho";
                vermelho++;
            }
            else if (cor == 1)
            {
                carros[i].Cor = "Verde";
                verde++;
            }
            else
            {
                carros[i].Cor = "Azul";
                azul++;
            }
        }

        // Exibe o resultado
        Console.WriteLine("Quantidade de carros por cor:");

        Console.WriteLine($"Vermelho: {vermelho}");
        Console.WriteLine($"Verde: {verde}");
        Console.WriteLine($"Azul: {azul}");
    }
}