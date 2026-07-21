/*• Volte no exercício anterior, crie uma lista de Animal, e instancie 3 Gatos e 3
Cachorros nela.
• Depois, percorra a lista e imprima as propriedades de Animal nela.*/
using System;
using System.Collections.Generic;

// Classe Pai
class Animal
{
    // Atributos protegidos
    // Podem ser acessados pelas classes filhas
    protected string nome;
    protected int idade;
    protected string cor;

    // Construtor da classe Animal
    public Animal(string nome, int idade, string cor)
    {
        this.nome = nome;
        this.idade = idade;
        this.cor = cor;
    }

    // Método para mostrar informações do animal
    public void MostrarPropriedades()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cor: {cor}");
    }

    // Métodos comuns
    public void Comer()
    {
        Console.WriteLine($"{nome} está comendo.");
    }

    public void Dormir()
    {
        Console.WriteLine($"{nome} está dormindo.");
    }
}

// Classe Cachorro
// Herda de Animal
class Cachorro : Animal
{
    private string raca;

    // Construtor do cachorro
    public Cachorro(string nome, int idade, string cor, string raca)
        : base(nome, idade, cor)
    {
        this.raca = raca;
    }


    public void Latir()
    {
        Console.WriteLine($"{nome} fez: Au Au!");
    }


    // Mostra informações específicas do cachorro
    public void MostrarRaca()
    {
        Console.WriteLine($"Raça: {raca}");
    }
}

// Classe Gato
// Herda de Animal
class Gato : Animal
{
    private bool temBigode;


    // Construtor do gato
    public Gato(string nome, int idade, string cor, bool temBigode)
        : base(nome, idade, cor)
    {
        this.temBigode = temBigode;
    }


    public void Miar()
    {
        Console.WriteLine($"{nome} fez: Miau!");
    }


    // Mostra informação específica do gato
    public void MostrarBigode()
    {
        Console.WriteLine($"Tem bigode: {temBigode}");
    }
}



class Program
{
    static void Main()
    {

        // Criando uma lista de Animal
        List<Animal> animais = new List<Animal>();


        // Adicionando 3 cachorros
        animais.Add(
            new Cachorro("Rex", 4, "Marrom", "Labrador")
        );

        animais.Add(
            new Cachorro("Bolt", 2, "Branco", "Poodle")
        );

        animais.Add(
            new Cachorro("Thor", 5, "Preto", "Pastor Alemão")
        );


        // Adicionando 3 gatos
        animais.Add(
            new Gato("Mingau", 3, "Branco", true)
        );

        animais.Add(
            new Gato("Nina", 1, "Cinza", true)
        );

        animais.Add(
            new Gato("Simba", 4, "Laranja", false)
        );

        // Percorrendo a lista
        foreach (Animal animal in animais)
        {
            Console.WriteLine("\n===== ANIMAL =====");

            // Chamando propriedades da classe Animal
            animal.MostrarPropriedades();
            animal.Comer();
            animal.Dormir();
        }

    }
}

