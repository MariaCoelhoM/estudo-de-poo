/*• Crie uma classe Animal abstrata, que tenham o método EmitirSom;
• Crie as classes Cachorro e Gato. Faça com que essas classes sobrescrevam o
método EmitirSom, imprimindo no console os respectivos sons dos animais;
• Crie uma instância para cada um destes animais, e guarde em uma lista de
Animal. Em seguida, percorra esta lista, chamando o método EmitirSom;*/
using System;
using System.Collections.Generic;

// Classe abstrata Animal
// Não pode ser instanciada
// Serve apenas como modelo para outras classes

abstract class Animal
{
    // Atributo protegido
    // Pode ser acessado pelas classes filhas
    protected string nome;

    // Construtor da classe Animal
    public Animal(string nome)
    {
        this.nome = nome;
    }

    // Método abstrato
    // Não possui implementação aqui
    // Toda classe que herdar de Animal
    // será obrigada a implementar esse método

    public abstract void EmitirSom();
}

// Classe Cachorro
// Herda da classe Animal
class Cachorro : Animal
{
    // Construtor
    // Chama o construtor da classe pai
    public Cachorro(string nome)
        : base(nome)
    {

    }

    // Sobrescreve o método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"{nome} faz: Au Au!");
    }

}

// Classe Gato
// Herda da classe Animal
class Gato : Animal
{

    // Construtor
    public Gato(string nome)
        : base(nome)
    {

    }


    // Sobrescreve o método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"{nome} faz: Miau!");
    }

}

// Classe principal

class Program
{
    static void Main()
    {
        // Criando uma lista do tipo Animal
        // A lista pode armazenar qualquer objeto
        // que herde da classe Animal
        List<Animal> animais = new List<Animal>();

        // Criando os objetos
        Cachorro cachorro = new Cachorro("Rex");
        Gato gato = new Gato("Mingau");

        // Adicionando os objetos na lista
        animais.Add(cachorro);
        animais.Add(gato);
        Console.WriteLine("===== Sons dos Animais =====\n");


        // Percorre toda a lista
        foreach (Animal animal in animais)
        {
            // Chama o método EmitirSom()
            // Cada objeto executará sua própria versão
            // do método (Polimorfismo)
            animal.EmitirSom();
        }

    }
}