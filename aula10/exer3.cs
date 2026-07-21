/*• Crie uma classe FormaGeometrica, que possui um método abstrato
CalcularArea.
• Crie as classes Quadrado, Retangulo, Circulo e Triangulo, que herdam de
FormaGeometrica. Implemente o método CalcularArea em cada método.
• Instancie Quadrado, Retangulo, Circulo e Triangulo em uma lista. Em seguida,
percorra a lista e execute CalcularArea.*/
using System;
using System.Collections.Generic;


// =======================================
// Classe abstrata FormaGeometrica
// =======================================
// A classe abstrata serve como um modelo.
// Não podemos criar objetos diretamente dela.
//
// Exemplo:
// FormaGeometrica forma = new FormaGeometrica();
// ERRO!
//
// Ela será usada apenas pelas classes filhas.

abstract class FormaGeometrica
{


    // Método abstrato
    //
    // Não possui código aqui.
    //
    // Todas as classes que herdarem de
    // FormaGeometrica serão obrigadas a
    // criar sua própria implementação.

    public abstract double CalcularArea();

}



// =======================================
// Classe Quadrado
// Herda de FormaGeometrica
// =======================================

class Quadrado : FormaGeometrica
{

    // Atributo do quadrado

    private double lado;



    // Construtor

    public Quadrado(double lado)
    {
        this.lado = lado;
    }



    // Implementação do método abstrato

    public override double CalcularArea()
    {
        // Fórmula:
        // área = lado * lado

        return lado * lado;
    }

}



// =======================================
// Classe Retangulo
// Herda de FormaGeometrica
// =======================================

class Retangulo : FormaGeometrica
{

    // Atributos do retângulo

    private double largura;
    private double altura;



    // Construtor

    public Retangulo(double largura, double altura)
    {
        this.largura = largura;
        this.altura = altura;
    }



    // Implementação do método abstrato

    public override double CalcularArea()
    {
        // Fórmula:
        // área = largura * altura

        return largura * altura;
    }

}



// =======================================
// Classe Circulo
// Herda de FormaGeometrica
// =======================================

class Circulo : FormaGeometrica
{

    // Raio do círculo

    private double raio;



    // Construtor

    public Circulo(double raio)
    {
        this.raio = raio;
    }



    // Implementação do método abstrato

    public override double CalcularArea()
    {
        // Fórmula:
        // área = π * raio²

        return Math.PI * Math.Pow(raio, 2);
    }

}



// =======================================
// Classe Triangulo
// Herda de FormaGeometrica
// =======================================

class Triangulo : FormaGeometrica
{

    // Atributos do triângulo

    private double baseTriangulo;
    private double altura;



    // Construtor

    public Triangulo(double baseTriangulo, double altura)
    {
        this.baseTriangulo = baseTriangulo;
        this.altura = altura;
    }



    // Implementação do método abstrato

    public override double CalcularArea()
    {
        // Fórmula:
        // área = (base * altura) / 2

        return (baseTriangulo * altura) / 2;
    }

}



// =======================================
// Classe principal
// =======================================

class Program
{

    static void Main()
    {


        // Criamos uma lista do tipo FormaGeometrica.
        //
        // Ela pode armazenar qualquer objeto
        // que herde de FormaGeometrica.
        //
        // Exemplo:
        // Quadrado é uma FormaGeometrica
        // Circulo é uma FormaGeometrica

        List<FormaGeometrica> formas = new List<FormaGeometrica>();



        // Criando os objetos

        Quadrado quadrado = new Quadrado(5);

        Retangulo retangulo = new Retangulo(10, 4);

        Circulo circulo = new Circulo(3);

        Triangulo triangulo = new Triangulo(6, 5);



        // Adicionando as formas na lista

        formas.Add(quadrado);

        formas.Add(retangulo);

        formas.Add(circulo);

        formas.Add(triangulo);



        Console.WriteLine("===== ÁREAS DAS FORMAS =====\n");



        // Percorrendo a lista

        foreach (FormaGeometrica forma in formas)
        {

            // Chamamos o mesmo método para todos:
            //
            // CalcularArea()
            //
            // Porém cada classe executa sua própria
            // versão do método.
            //
            // Isso é POLIMORFISMO.

            Console.WriteLine(
                $"Área: {forma.CalcularArea():F2}"
            );

        }


    }

}