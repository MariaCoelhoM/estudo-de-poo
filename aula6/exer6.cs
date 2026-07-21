/*• Volte no exercício anterior, e inclua a possibilidade de ter animais voadores,
animais terrestres e animais aquáticos. Crie, também, a possibilidade de ter
pássaros e peixes.*/
using System;
using System.Collections.Generic;

// Classe base de todos os animais
abstract class Animal
{
    protected string nome;
    protected int idade;

    // Construtor da classe Animal
    public Animal(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    // Método comum a todos os animais
    public void MostrarInformacoes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
    }

    public void Comer()
    {
        Console.WriteLine($"{nome} está comendo.");
    }
}

// Classe para animais que voam
abstract class AnimalVoador : Animal
{

    public AnimalVoador(string nome, int idade)
        : base(nome, idade)
    {

    }

    // Comportamento específico de animais voadores
    public void Voar()
    {
        Console.WriteLine($"{nome} está voando.");
    }
}

// Classe para animais terrestres
abstract class AnimalTerrestre : Animal
{

    public AnimalTerrestre(string nome, int idade)
        : base(nome, idade)
    {

    }

    public void Andar()
    {
        Console.WriteLine($"{nome} está andando.");
    }
}

// Classe para animais aquáticos
abstract class AnimalAquatico : Animal
{

    public AnimalAquatico(string nome, int idade)
        : base(nome, idade)
    {

    }

    public void Nadar()
    {
        Console.WriteLine($"{nome} está nadando.");
    }
}

// Classe Cachorro
// Herda de AnimalTerrestre

class Cachorro : AnimalTerrestre
{
    private string raca;

    public Cachorro(string nome, int idade, string raca)
        : base(nome, idade)
    {
        this.raca = raca;
    }

    public void Latir()
    {
        Console.WriteLine($"{nome}: Au Au!");
    }

    public void MostrarDados()
    {
        MostrarInformacoes();
        Console.WriteLine($"Raça: {raca}");
    }
}

// Classe Gato
// Herda de AnimalTerrestre
class Gato : AnimalTerrestre
{

    private bool temBigode;

    public Gato(string nome, int idade, bool temBigode)
        : base(nome, idade)
    {
        this.temBigode = temBigode;
    }

    public void Miar()
    {
        Console.WriteLine($"{nome}: Miau!");
    }

    public void MostrarDados()
    {
        MostrarInformacoes();
        Console.WriteLine($"Tem bigode: {temBigode}");
    }
}

// Classe Passaro
// Herda de AnimalVoador
class Passaro : AnimalVoador
{
    private string especie;

    public Passaro(string nome, int idade, string especie)
        : base(nome, idade)
    {
        this.especie = especie;
    }

    public void Cantar()
    {
        Console.WriteLine($"{nome} está cantando.");
    }

    public void MostrarDados()
    {
        MostrarInformacoes();
        Console.WriteLine($"Espécie: {especie}");
    }
}

// Classe Peixe
// Herda de AnimalAquatico
class Peixe : AnimalAquatico
{

    private string tipo;

    public Peixe(string nome, int idade, string tipo)
        : base(nome, idade)
    {
        this.tipo = tipo;
    }

    public void MostrarDados()
    {
        MostrarInformacoes();
        Console.WriteLine($"Tipo: {tipo}");
    }
}

class Program
{

    static void Main()
    {
        // Lista contendo diferentes tipos de animais
        List<Animal> animais = new List<Animal>();

        // Adicionando animais terrestres
        animais.Add(
            new Cachorro("Rex", 4, "Labrador")
        );

        animais.Add(
            new Gato("Mingau", 2, true)
        );

        // Adicionando animal voador
        animais.Add(
            new Passaro("Piu", 1, "Canário")
        );

        // Adicionando animal aquático
        animais.Add(
            new Peixe("Nemo", 3, "Peixe-palhaço")
        );

        // Percorrendo todos os animais
        foreach(Animal animal in animais)
        {

            Console.WriteLine("\n=================");
            animal.MostrarInformacoes();
            animal.Comer();

            // Verifica se é terrestre
            if(animal is AnimalTerrestre)
            {
                AnimalTerrestre terrestre = (AnimalTerrestre)animal;
                terrestre.Andar();
            }

            // Verifica se é voador
            if(animal is AnimalVoador)
            {
                AnimalVoador voador = (AnimalVoador)animal;
                voador.Voar();
            }

            // Verifica se é aquático
            if(animal is AnimalAquatico)
            {
                AnimalAquatico aquatico = (AnimalAquatico)animal;
                aquatico.Nadar();
            }

            // Verifica se é cachorro
            if(animal is Cachorro)
            {
                Cachorro cachorro = (Cachorro)animal;
                cachorro.Latir();
            }

            // Verifica se é gato
            if(animal is Gato)
            {
                Gato gato = (Gato)animal;
                gato.Miar();
            }

            // Verifica se é pássaro
            if(animal is Passaro)
            {
                Passaro passaro = (Passaro)animal;
                passaro.Cantar();
            }

        }

    }
}