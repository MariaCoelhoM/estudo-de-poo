/*• Modifique o exercício 3 para definir os níveis de acesso para cada atributo
• Crie propriedades para encapsular os atributos*/
using System;
// Classe que representa um personagem
class Personagem
{
    // Atributos privados
    // Só podem ser acessados dentro da classe

    private string nome;
    private int hp;
    private int ataque;
    private int defesa;

    // Propriedades
    // Permitem acessar os atributos privados
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }

    public int Ataque
    {
        get { return ataque; }
        set { ataque = value; }
    }

    public int Defesa
    {
        get { return defesa; }
        set { defesa = value; }
    }

    // Método para atacar
    public void Atacar(Personagem inimigo)
    {
        // Não permite atacar quem já morreu
        if (inimigo.HP <= 0)
        {
            Console.WriteLine($"{inimigo.Nome} já foi derrotado.");
            return;
        }

        // Calcula o dano
        int dano = Ataque - inimigo.Defesa;

        // Não permite dano negativo
        if (dano < 0)
        {
            dano = 0;
        }

        // Aplica o dano
        inimigo.HP -= dano;

        // Não permite HP negativo
        if (inimigo.HP < 0)
        {
            inimigo.HP = 0;
        }

        Console.WriteLine($"{Nome} atacou {inimigo.Nome}!");
        Console.WriteLine($"Dano causado: {dano}");
        Console.WriteLine($"HP restante: {inimigo.HP}");

        // Verifica se morreu
        if (inimigo.HP == 0)
        {
            Console.WriteLine($"{inimigo.Nome} foi derrotado!");
        }
    }

    // Exibe os atributos
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
        // Primeiro personagem
        Personagem guerreiro = new Personagem();

        guerreiro.Nome = "Guerreiro";
        guerreiro.HP = 100;
        guerreiro.Ataque = 30;
        guerreiro.Defesa = 10;

        // Segundo personagem
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