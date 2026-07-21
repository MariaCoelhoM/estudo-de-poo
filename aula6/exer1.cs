/*• Crie um programa que simule os comportamentos de um cachorro e um gato
• Reflita sobre o que um cachorro e um gato possuem em comum, e crie uma
classe pai que tenha os atributos e métodos que eles possuem em comum
• Reflita sobre o que um cachorro e um gato possuem de diferente, e crie suas
classes herdando da classe pai, com atributos e métodos únicos
• Crie uma instância para cada uma das classes*/
using System;
// Classe Pai
// Representa qualquer animal
class Animal
{
    // Atributos comuns a todos os animais
    public string Nome;
    public int Idade;
    public string Cor;

    // Método comum
    public void Dormir()
    {
        Console.WriteLine($"{Nome} está dormindo.");
    }

    // Método comum
    public void Comer()
    {
        Console.WriteLine($"{Nome} está comendo.");
    }
}
// Classe Cachorro
// Herda da classe Animal
class Cachorro : Animal
{
    // Atributo exclusivo do cachorro
    public string Raca;

    // Método exclusivo
    public void Latir()
    {
        Console.WriteLine($"{Nome} fez: Au Au!");
    }
}
// Classe Gato
// Herda da classe Animal
class Gato : Animal
{
    // Atributo exclusivo do gato
    public bool TemBigode;

    // Método exclusivo
    public void Miar()
    {
        Console.WriteLine($"{Nome} fez: Miau!");
    }
}

class Program
{
    static void Main()
    {
        // Criando um cachorro
        Cachorro cachorro = new Cachorro();

        cachorro.Nome = "Rex";
        cachorro.Idade = 4;
        cachorro.Cor = "Marrom";
        cachorro.Raca = "Labrador";

        // Criando um gato
        Gato gato = new Gato();

        gato.Nome = "Mingau";
        gato.Idade = 2;
        gato.Cor = "Branco";
        gato.TemBigode = true;

        // Comportamentos do cachorro
        Console.WriteLine("===== CACHORRO =====");
        Console.WriteLine($"Nome: {cachorro.Nome}");
        Console.WriteLine($"Idade: {cachorro.Idade}");
        Console.WriteLine($"Cor: {cachorro.Cor}");
        Console.WriteLine($"Raça: {cachorro.Raca}");

        cachorro.Comer();
        cachorro.Dormir();
        cachorro.Latir();

        Console.WriteLine();

        // Comportamentos do gato
        Console.WriteLine("===== GATO =====");
        Console.WriteLine($"Nome: {gato.Nome}");
        Console.WriteLine($"Idade: {gato.Idade}");
        Console.WriteLine($"Cor: {gato.Cor}");
        Console.WriteLine($"Tem bigode? {gato.TemBigode}");

        gato.Comer();
        gato.Dormir();
        gato.Miar();
    }
}