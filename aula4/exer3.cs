/*• Implemente um software que simula um jogo de RPG
• Crie uma classe Personagem, que possui HP, ataque e defesa
• Um Personagem deve poder atacar um Personagem
• Ao atacar um personagem, deve-se gerar dano no personagem atacado
através da seguinte formula:
HPatacado = HPatacado - (Ataqueatacante - Defesaatacado)
• Não deve ser possível atacar um personagem que está com o HP igual ou
menor a 0*/
using System;
// Classe que representa um personagem do jogo
class Personagem
{
    // Atributos do personagem
    public string Nome;
    public int HP;
    public int Ataque;
    public int Defesa;

    // Método para atacar outro personagem
    public void Atacar(Personagem inimigo)
    {
        // Verifica se o inimigo já foi derrotado
        if (inimigo.HP <= 0)
        {
            Console.WriteLine($"{inimigo.Nome} já foi derrotado e não pode mais ser atacado.");
            return; // Encerra o método
        }

        // Calcula o dano
        int dano = Ataque - inimigo.Defesa;

        // Se o dano for negativo, considera dano igual a 0
        if (dano < 0)
        {
            dano = 0;
        }

        // Aplica o dano no HP do inimigo
        inimigo.HP -= dano;

        // Impede que o HP fique negativo
        if (inimigo.HP < 0)
        {
            inimigo.HP = 0;
        }

        Console.WriteLine($"{Nome} atacou {inimigo.Nome}!");
        Console.WriteLine($"Dano causado: {dano}");
        Console.WriteLine($"HP restante de {inimigo.Nome}: {inimigo.HP}");

        // Verifica se o inimigo foi derrotado
        if (inimigo.HP == 0)
        {
            Console.WriteLine($"{inimigo.Nome} foi derrotado!");
        }
    }

    // Método para mostrar os atributos do personagem
    public void MostrarStatus()
    {
        Console.WriteLine("\n===== PERSONAGEM =====");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"HP: {HP}");
        Console.WriteLine($"Ataque: {Ataque}");
        Console.WriteLine($"Defesa: {Defesa}");
    }
}

class Program
{
    static void Main()
    {
        // Cria o primeiro personagem
        Personagem guerreiro = new Personagem();

        guerreiro.Nome = "Guerreiro";
        guerreiro.HP = 100;
        guerreiro.Ataque = 30;
        guerreiro.Defesa = 10;

        // Cria o segundo personagem
        Personagem arqueiro = new Personagem();

        arqueiro.Nome = "Arqueiro";
        arqueiro.HP = 80;
        arqueiro.Ataque = 25;
        arqueiro.Defesa = 5;

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Guerreiro ataca Arqueiro");
            Console.WriteLine("2 - Arqueiro ataca Guerreiro");
            Console.WriteLine("3 - Mostrar status");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    guerreiro.Atacar(arqueiro);
                    break;

                case 2:
                    arqueiro.Atacar(guerreiro);
                    break;

                case 3:
                    guerreiro.MostrarStatus();
                    arqueiro.MostrarStatus();
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