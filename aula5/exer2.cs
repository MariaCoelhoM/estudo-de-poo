/*• Utilizando Programação Orientada a Objeto, crie um programa que contém a
classe retângulo
• Um retângulo deve ter altura e largura privados
• Deve haver um método para calcular a área
• Deve haver um método para calcular o perímetro*/
using System;

// Classe Retangulo
class Retangulo
{
    // Atributos privados
    // Só podem ser acessados dentro da classe
    private double altura;
    private double largura;

    // Propriedades
    // Permitem acessar os atributos privados
    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public double Largura
    {
        get { return largura; }
        set { largura = value; }
    }

    // Método para calcular a área
    // Fórmula: Área = altura × largura
    public double CalcularArea()
    {
        return Altura * Largura;
    }

    // Método para calcular o perímetro
    // Fórmula: Perímetro = 2 × (altura + largura)
    public double CalcularPerimetro()
    {
        return 2 * (Altura + Largura);
    }

    // Método para mostrar os dados
    public void MostrarDados()
    {
        Console.WriteLine("\n===== RETÂNGULO =====");
        Console.WriteLine($"Altura: {Altura}");
        Console.WriteLine($"Largura: {Largura}");
        Console.WriteLine($"Área: {CalcularArea()}");
        Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
    }
}

class Program
{
    static void Main()
    {
        // Cria um objeto da classe Retangulo
        Retangulo retangulo = new Retangulo();

        // Lê os valores informados pelo usuário
        Console.Write("Digite a altura: ");
        retangulo.Altura = double.Parse(Console.ReadLine());

        Console.Write("Digite a largura: ");
        retangulo.Largura = double.Parse(Console.ReadLine());

        // Exibe os resultados
        retangulo.MostrarDados();
    }
}