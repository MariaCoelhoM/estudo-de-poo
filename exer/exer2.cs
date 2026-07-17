using System;

class Carro
{
    // Atributos
    public string Marca;
    public string Modelo;
    public int Ano;

    // Método
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca:  {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Carro carro = new Carro();

        Console.Write("Digite aqui a Marca: ");
        carro.Marca = Console.ReadLine();

        Console.Write("Digite aqui a Modelo: ");
        carro.Modelo = Console.ReadLine();

        Console.Write("Digite aqui o Ano: ");
        carro.Ano = int.Parse(Console.ReadLine());

        Console.WriteLine();
        carro.ExibirInformacoes();
    }
}