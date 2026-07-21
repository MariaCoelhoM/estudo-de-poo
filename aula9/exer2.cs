/*• Faça um pequeno jogo de RPG que tenha a classe Personagem, onde um
Personagem possui uma quantidade de vida e uma quantidade de dano. Um
Personagem também pode atacar outro Personagem;
• Crie 2 classes que herdem de Personagem:
• Guerreiro: Ao atacar, possui 30% de chance de realizar dois ataques em
seguida;
• Arqueiro: Possui uma quantidade de flechas. Ao atacar, gasta 1 flecha.
Não pode atacar se não tiver flechas o suficiente;*/
using System;

// Classe Pai: Personagem
class Personagem
{
    // Atributos protegidos
    // As classes filhas poderão acessar

    protected string nome;
    protected int vida;
    protected int dano;

    // Construtor da classe Personagem
    public Personagem(string nome, int vida, int dano)
    {
        this.nome = nome;
        this.vida = vida;
        this.dano = dano;
    }

    // Método de ataque comum
    public virtual void Atacar(Personagem inimigo)
    {
        Console.WriteLine($"{nome} atacou {inimigo.nome}");
        inimigo.ReceberDano(dano);
    }

    // Método que recebe dano
    public void ReceberDano(int danoRecebido)
    {
        vida -= danoRecebido;

        // Impede vida negativa
        if (vida < 0)
        {
            vida = 0;
        }

        Console.WriteLine($"{nome} recebeu {danoRecebido} de dano.");
        Console.WriteLine($"Vida atual: {vida}");
    }

    // Mostra informações do personagem
    public void MostrarStatus()
    {
        Console.WriteLine(
            $"{nome} - Vida: {vida} - Dano: {dano}"
        );
    }
}

// Classe Guerreiro
// Herda de Personagem
class Guerreiro : Personagem
{
    // Gerador de números aleatórios
    Random random = new Random();

    // Construtor
    public Guerreiro(string nome, int vida, int dano)
        : base(nome, vida, dano)
    {

    }

    // Guerreiro sobrescreve o ataque
    public override void Atacar(Personagem inimigo)
    {
        Console.WriteLine($"\nTurno de ataque: {nome}");
        Console.WriteLine($"{nome} atacou como Guerreiro!");

        // Primeiro ataque sempre acontece
        inimigo.ReceberDano(dano);

        // Gera um número de 0 até 99
        int chance = random.Next(100);

        // 30% de chance de atacar novamente
        if (chance < 30)
        {
            Console.WriteLine($"{nome} conseguiu realizar um segundo ataque!");
            inimigo.ReceberDano(dano);
        }

    }

}

// Classe Arqueiro
// Herda de Personagem
class Arqueiro : Personagem
{
    private int flechas;
    // Construtor
    public Arqueiro(
        string nome,
        int vida,
        int dano,
        int flechas
    )
        : base(nome, vida, dano)
    {
        this.flechas = flechas;
    }
    
    // Ataque especial do Arqueiro
    public override void Atacar(Personagem inimigo)
    {
        // Verifica se possui flechas
        if (flechas <= 0)
        {
            Console.WriteLine($"{nome} não possui flechas para atacar!");
            return;
        }

        // Gasta uma flecha
        flechas--;

        Console.WriteLine($"{nome} disparou uma flecha!");
        inimigo.ReceberDano(dano);
        Console.WriteLine(
            $"Flechas restantes: {flechas}"
        );

    }

}

class Program
{
    static void Main()
    {

        // Criando personagens
        Guerreiro guerreiro = new Guerreiro(
            "Arthur",
            100,
            20
        );


        Arqueiro arqueiro = new Arqueiro(
            "Legolas",
            80,
            15,
            3
        );

        Console.WriteLine("===== STATUS INICIAL =====");
        guerreiro.MostrarStatus();
        arqueiro.MostrarStatus();

        // Batalha
        Console.WriteLine("\n===== BATALHA =====");

        // Guerreiro ataca arqueiro
        guerreiro.Atacar(arqueiro);
        Console.WriteLine();

        // Arqueiro ataca guerreiro
        arqueiro.Atacar(guerreiro);
        Console.WriteLine();

        // Mais ataques do arqueiro
        // para mostrar gasto de flechas
        arqueiro.Atacar(guerreiro);
        arqueiro.Atacar(guerreiro);
        arqueiro.Atacar(guerreiro);

        Console.WriteLine("\n===== STATUS FINAL =====");
        guerreiro.MostrarStatus();
        arqueiro.MostrarStatus();
    }
}