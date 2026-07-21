//• Utilizando o Exercício 1, faça com que o método EmitirSom seja abstrato.
using System;
using System.Collections.Generic;

// =======================================
// Classe abstrata Animal
// =======================================

// Uma classe abstrata serve como modelo.
// Não podemos criar objetos diretamente dela.
//
// Exemplo:
// Animal animal = new Animal(); ❌ ERRO
//
// Podemos apenas criar objetos das classes
// que herdam dela.

abstract class Animal
{

    // Atributo protegido
    // As classes filhas poderão acessar

    protected string nome;



    // Construtor da classe Animal

    public Animal(string nome)
    {
        this.nome = nome;
    }



    // Método abstrato
    //
    // Ele não possui implementação aqui.
    //
    // As classes filhas são obrigadas a criar
    // sua própria versão desse método usando override.

    public abstract void EmitirSom();

}



// =======================================
// Classe Cachorro
// Herda da classe Animal
// =======================================

class Cachorro : Animal
{

    // Construtor do Cachorro

    public Cachorro(string nome)
        : base(nome)
    {

    }



    // Implementação obrigatória do método abstrato

    public override void EmitirSom()
    {
        Console.WriteLine($"{nome} faz: Au Au!");
    }

}



// =======================================
// Classe Gato
// Herda da classe Animal
// =======================================

class Gato : Animal
{

    // Construtor do Gato

    public Gato(string nome)
        : base(nome)
    {

    }



    // Implementação obrigatória do método abstrato

    public override void EmitirSom()
    {
        Console.WriteLine($"{nome} faz: Miau!");
    }

}



// =======================================
// Programa principal
// =======================================

class Program
{

    static void Main()
    {

        // Criando uma lista do tipo Animal
        //
        // Ela pode guardar objetos de qualquer
        // classe que herde de Animal.

        List<Animal> animais = new List<Animal>();



        // Criando objetos das classes filhas

        Cachorro cachorro = new Cachorro("Rex");

        Gato gato = new Gato("Mingau");



        // Adicionando os objetos na lista

        animais.Add(cachorro);

        animais.Add(gato);



        Console.WriteLine("===== Sons dos Animais =====\n");



        // Percorrendo a lista

        foreach (Animal animal in animais)
        {

            // O C# identifica qual objeto está sendo usado.
            //
            // Se for Cachorro:
            // chama EmitirSom() do Cachorro
            //
            // Se for Gato:
            // chama EmitirSom() do Gato
            //
            // Isso é polimorfismo.

            animal.EmitirSom();

        }

    }

}