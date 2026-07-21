/*• Crie uma classe Animal que tenha o método EmitirSom;
• Crie as classes Cachorro, Gato, Peixe e Pássaro que herdam de Animal. Faça
com que essas classes sobrescrevam o método EmitirSom, imprimindo no
console os respectivos sons dos animais;
• Crie uma instância para cada um destes animais, e guarde em uma lista de
Animal. Em seguida, percorra esta lista, chamando o método EmitirSom;*/
using System;
using System.Collections.Generic;

// Classe Pai
class Animal
{
    // Método virtual
    // Permite que as classes filhas sobrescrevam esse método
    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal emitiu um som.");
    }
}

// Classe Cachorro
// Herda de Animal
class Cachorro : Animal
{
    // Sobrescrevendo o método da classe pai
    public override void EmitirSom()
    {
        Console.WriteLine("Cachorro: Au Au!");
    }

}

// Classe Gato
// Herda de Animal
class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Gato: Miau!");
    }
}

// Classe Peixe
// Herda de Animal

class Peixe : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Peixe: Glub Glub!");
    }

}

// Classe Passaro
// Herda de Animal
class Passaro : Animal
{

    public override void EmitirSom()
    {
        Console.WriteLine("Pássaro: Piu Piu!");
    }

}

class Program
{
    static void Main()
    {
        // Criando uma lista de Animal
        List<Animal> animais = new List<Animal>();

        // Adicionando diferentes animais
        // na lista
        animais.Add(new Cachorro());
        animais.Add(new Gato());
        animais.Add(new Peixe());
        animais.Add(new Passaro());

        // Percorrendo a lista
        foreach(Animal animal in animais)
        {
            // Mesmo chamando o método Animal,
            // cada objeto executa sua própria versão
            animal.EmitirSom();

        }

    }
}