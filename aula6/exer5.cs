/*• Volte no exercício anterior, e a partir da iteração na lista, imprima, também,
os atributos específicos de Cachorro e de Gato. Da mesma forma, execute os
métodos específicos de Cachorro e de Gato.*/
using System;
using System.Collections.Generic;

// Classe Pai
class Animal
{
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

    // Método comum dos animais
    public void MostrarPropriedades()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cor: {cor}");
    }

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
class Cachorro : Animal
{
    private string raca;

    // Construtor do cachorro
    public Cachorro(string nome, int idade, string cor, string raca)
        : base(nome, idade, cor)
    {
        this.raca = raca;
    }

    // Método específico do cachorro
    public void Latir()
    {
        Console.WriteLine($"{nome} fez: Au Au!");
    }

    // Mostra atributo específico
    public void MostrarDadosCachorro()
    {
        Console.WriteLine($"Raça: {raca}");
    }
}

// Classe Gato
class Gato : Animal
{
    private bool temBigode;

    // Construtor do gato
    public Gato(string nome, int idade, string cor, bool temBigode)
        : base(nome, idade, cor)
    {
        this.temBigode = temBigode;
    }


    // Método específico do gato
    public void Miar()
    {
        Console.WriteLine($"{nome} fez: Miau!");
    }


    // Mostra atributo específico
    public void MostrarDadosGato()
    {
        Console.WriteLine($"Tem bigode: {temBigode}");
    }
}

class Program
{
    static void Main()
    {
        // Criando lista de Animal
        List<Animal> animais = new List<Animal>();
        // Adicionando cachorros
        animais.Add(
            new Cachorro("Rex", 4, "Marrom", "Labrador")
        );

        animais.Add(
            new Cachorro("Bolt", 2, "Branco", "Poodle")
        );

        animais.Add(
            new Cachorro("Thor", 5, "Preto", "Pastor Alemão")
        );

        // Adicionando gatos

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

            // Propriedades da classe pai
            animal.MostrarPropriedades();

            // Métodos comuns
            animal.Comer();
            animal.Dormir();

            // Verifica se é um Cachorro
            if (animal is Cachorro)
            {
                // Faz o downcasting
                Cachorro cachorro = (Cachorro)animal;

                Console.WriteLine("\n--- Dados do Cachorro ---");

                // Acessa atributo específico
                cachorro.MostrarDadosCachorro();

                // Executa método específico
                cachorro.Latir();
            }

            // Verifica se é um Gato
            if (animal is Gato)
            {
                // Faz o downcasting
                Gato gato = (Gato)animal;

                Console.WriteLine("\n--- Dados do Gato ---");

                // Acessa atributo específico
                gato.MostrarDadosGato();

                // Executa método específico
                gato.Miar();
            }

        }

    }
}

