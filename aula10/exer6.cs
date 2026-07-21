/*• Utilizando a classe Animal:
• Faça com que Animal seja abstrata e tenha atributos de nome, raça e
idade
• Crie construtores que tenham apenas nome, nome + raça, e nome +
raça + idade
• Faça com que as classes Gato e Cachorro herdem de Animal
• Instancie pelo menos 1 Gato e 1 Cachorro*/
using System;


// =======================================
// Classe abstrata Animal
// Classe pai
// =======================================

// Como é abstrata, não podemos criar objetos
// diretamente dela.
//
// Exemplo:
// Animal animal = new Animal(); ❌
//
// Ela será usada como base para Gato e Cachorro.

abstract class Animal
{

    // =======================================
    // Atributos da classe Animal
    // =======================================

    protected string nome;
    protected string raca;
    protected int idade;



    // =======================================
    // Construtor 1
    // Recebe apenas o nome
    // =======================================

    public Animal(string nome)
    {
        this.nome = nome;

        // Como não recebemos raça e idade,
        // colocamos valores padrão.

        this.raca = "Não informado";
        this.idade = 0;
    }




    // =======================================
    // Construtor 2
    // Recebe nome + raça
    // =======================================

    public Animal(string nome, string raca)
    {
        this.nome = nome;
        this.raca = raca;

        // Idade não foi informada

        this.idade = 0;
    }




    // =======================================
    // Construtor 3
    // Recebe nome + raça + idade
    // =======================================

    public Animal(
        string nome,
        string raca,
        int idade
    )
    {
        this.nome = nome;
        this.raca = raca;
        this.idade = idade;
    }




    // =======================================
    // Método para mostrar informações
    // =======================================

    public void MostrarInformacoes()
    {
        Console.WriteLine(
            $"Nome: {nome} | Raça: {raca} | Idade: {idade} anos"
        );
    }

}





// =======================================
// Classe Cachorro
// Herda de Animal
// =======================================

class Cachorro : Animal
{


    // Construtor usando apenas nome

    public Cachorro(string nome)
        : base(nome)
    {

    }




    // Construtor usando nome + raça

    public Cachorro(
        string nome,
        string raca
    )
        : base(nome, raca)
    {

    }




    // Construtor usando nome + raça + idade

    public Cachorro(
        string nome,
        string raca,
        int idade
    )
        : base(nome, raca, idade)
    {

    }

}





// =======================================
// Classe Gato
// Herda de Animal
// =======================================

class Gato : Animal
{


    // Construtor usando apenas nome

    public Gato(string nome)
        : base(nome)
    {

    }




    // Construtor usando nome + raça

    public Gato(
        string nome,
        string raca
    )
        : base(nome, raca)
    {

    }




    // Construtor usando nome + raça + idade

    public Gato(
        string nome,
        string raca,
        int idade
    )
        : base(nome, raca, idade)
    {

    }

}





// =======================================
// Classe principal
// =======================================

class Program
{

    static void Main()
    {


        // =======================================
        // Criando um cachorro
        // Usando o construtor completo
        // =======================================

        Cachorro cachorro = new Cachorro(
            "Rex",
            "Golden Retriever",
            5
        );



        // =======================================
        // Criando um gato
        // Usando o construtor nome + raça
        // =======================================

        Gato gato = new Gato(
            "Mingau",
            "Persa"
        );



        Console.WriteLine("===== ANIMAIS =====\n");



        // Mostrando informações

        cachorro.MostrarInformacoes();

        gato.MostrarInformacoes();



    }

}