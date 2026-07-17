using System;

class Animal
{
    // Atributos
    public string Nome;
    public string Especie;
    public int Idade;

    // Método
    public void EmitirInformacoes()
    {
        Console.WriteLine($"Produto:  {Nome}");
        Console.WriteLine($"Espécie: {Especie}");
        Console.WriteLine($"Idade: {Idade} anos");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Animal animal = new Animal();

        Console.Write("Digite aqui o Nome: ");
        animal.Nome = Console.ReadLine();

        Console.Write("Digite aqui a Espécie: ");
        animal.Especie = Console.ReadLine();

        Console.Write("Digite aqui a Idade: ");
        animal.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        animal.EmitirInformacoes();
    }
}