//faça 3 instâncias de carros, e atribua uma cor diferente
//para cada. Imprima cada um no terminal.
using System;

// Classe Carro
class Carro
{
    // Atributos da classe
    public string Marca;
    public string Modelo;
    public string Cor;
}

class Program
{
    static void Main()
    {
        // Criação do primeiro carro
        Carro carro1 = new Carro(); // Instancia um objeto da classe Carro

        carro1.Marca = "Toyota";
        carro1.Modelo = "Corolla";
        carro1.Cor = "Preto";

        // Criação do segundo carro
        Carro carro2 = new Carro();

        carro2.Marca = "Honda";
        carro2.Modelo = "Civic";
        carro2.Cor = "Branco";

        // Criação do terceiro carro
        Carro carro3 = new Carro();

        carro3.Marca = "Ford";
        carro3.Modelo = "Mustang";
        carro3.Cor = "Vermelho";

        // Impressão dos carros

        Console.WriteLine("=== CARRO 1 ===");
        Console.WriteLine($"Marca: {carro1.Marca}");
        Console.WriteLine($"Modelo: {carro1.Modelo}");
        Console.WriteLine($"Cor: {carro1.Cor}");

        Console.WriteLine();

        Console.WriteLine("=== CARRO 2 ===");
        Console.WriteLine($"Marca: {carro2.Marca}");
        Console.WriteLine($"Modelo: {carro2.Modelo}");
        Console.WriteLine($"Cor: {carro2.Cor}");

        Console.WriteLine();

        Console.WriteLine("=== CARRO 3 ===");
        Console.WriteLine($"Marca: {carro3.Marca}");
        Console.WriteLine($"Modelo: {carro3.Modelo}");
        Console.WriteLine($"Cor: {carro3.Cor}");
    }
}