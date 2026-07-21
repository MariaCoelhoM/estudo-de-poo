/*• Volte no exercício anterior, e crie um construtor para Animal. Em seguida,
crie construtores para Cachorro e Gato que utilizem o construtor de Animal.*/
using System;
// Classe Pai
class Animal
{
    // Atributos protegidos
    // Podem ser acessados pela classe Animal
    // e pelas classes que herdam dela
    protected string nome;
    protected int idade;
    protected string cor;

    // Construtor da classe Animal
    // Recebe os dados comuns
    public Animal(string nome, int idade, string cor)
    {
        this.nome = nome;
        this.idade = idade;
        this.cor = cor;
    }

    // Método comum para todos os animais
    public void Comer()
    {
        Console.WriteLine($"{nome} está comendo.");
    }

    // Método comum para todos os animais
    public void Dormir()
    {
        Console.WriteLine($"{nome} está dormindo.");
    }
}

// Classe Cachorro
// Herda de Animal
class Cachorro : Animal
{
    // Atributo exclusivo do cachorro
    private string raca;

    // Construtor do Cachorro
    public Cachorro(string nome, int idade, string cor, string raca)
        : base(nome, idade, cor)
    {
        // Inicializa o atributo específico do cachorro
        this.raca = raca;
    }

    // Método exclusivo do cachorro
    public void Latir()
    {
        Console.WriteLine($"{nome} fez: Au Au!");
    }

    public void MostrarDados()
    {
        Console.WriteLine("\n===== CACHORRO =====");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Raça: {raca}");
    }
}
// Classe Gato
// Herda de Animal

class Gato : Animal
{
    // Atributo exclusivo do gato
    private bool temBigode;

    // Construtor do Gato
    public Gato(string nome, int idade, string cor, bool temBigode)
        : base(nome, idade, cor)
    {
        // Inicializa o atributo específico do gato
        this.temBigode = temBigode;
    }

    // Método exclusivo do gato
    public void Miar()
    {
        Console.WriteLine($"{nome} fez: Miau!");
    }

    public void MostrarDados()
    {
        Console.WriteLine("\n===== GATO =====");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Tem bigode? {temBigode}");
    }
}


class Program
{
    static void Main()
    {

        // Criando um cachorro
        // Usando o construtor
        Cachorro cachorro = new Cachorro(
            "Rex",
            4,
            "Marrom",
            "Labrador"
        );

        // Criando um gato
        // Usando o construtor
        Gato gato = new Gato(
            "Mingau",
            2,
            "Branco",
            true
        );

        // Exibindo informações
        cachorro.MostrarDados();
        cachorro.Comer();
        cachorro.Dormir();
        cachorro.Latir();

        gato.MostrarDados();
        gato.Comer();
        gato.Dormir();
        gato.Miar();

    }
}



