/*Volte no exercício anterior, e garanta que apenas as classes de Cachorro e
Gato possam ter acesso aos atributos da classe Animal*/
using System;
// Classe Pai
class Animal
{
    // Atributos protegidos
    // Apenas Animal e suas classes filhas podem acessar
    protected string nome;
    protected int idade;
    protected string cor;

    // Método para definir os dados do animal
    public void DefinirDados(string nome, int idade, string cor)
    {
        //O this serve para se referir ao atributo do próprio objeto (da classe).
        //O C# fica confuso porque os dois têm o mesmo nome.
        this.nome = nome;
        this.idade = idade;
        this.cor = cor;
    }

    // Método comum
    public void Comer()
    {
        Console.WriteLine($"{nome} está comendo.");
    }

    // Método comum
    public void Dormir()
    {
        Console.WriteLine($"{nome} está dormindo.");
    }
}

// Classe Cachorro
class Cachorro : Animal
{
    // Atributo exclusivo
    public string Raca;

    // Método exclusivo
    public void Latir()
    {
        Console.WriteLine($"{nome} fez: Au Au!");
    }

    // Mostra todas as informações do cachorro
    public void MostrarDados()
    {
        Console.WriteLine("===== CACHORRO =====");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Raça: {Raca}");
    }
}
// Classe Gato
class Gato : Animal
{
    // Atributo exclusivo
    public bool TemBigode;

    // Método exclusivo
    public void Miar()
    {
        Console.WriteLine($"{nome} fez: Miau!");
    }

    // Mostra todas as informações do gato
    public void MostrarDados()
    {
        Console.WriteLine("===== GATO =====");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Tem bigode? {TemBigode}");
    }
}

class Program
{
    static void Main()
    {
        // Cria um cachorro
        Cachorro cachorro = new Cachorro();

        cachorro.DefinirDados("Rex", 4, "Marrom");
        cachorro.Raca = "Labrador";

        cachorro.MostrarDados();
        cachorro.Comer();
        cachorro.Dormir();
        cachorro.Latir();

        Console.WriteLine();

        // Cria um gato
        Gato gato = new Gato();

        gato.DefinirDados("Mingau", 2, "Branco");
        gato.TemBigode = true;

        gato.MostrarDados();
        gato.Comer();
        gato.Dormir();
        gato.Miar();
    }
}