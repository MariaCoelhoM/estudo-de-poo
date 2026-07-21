/*• Usando o sistema de RPG feito na aula passada:
• Faça com que um Personagem possa ser criado:
• sem parâmetros (atribuindo vida e valor de ataque padrão)
• apenas com vida (atribuindo valor padrão a ataque)
• com vida e com ataque
• Faça com que um Personagem possa atacar apenas um Personagem ou
uma lista de Personagem*/
using System;
using System.Collections.Generic;


// =======================================
// Classe Personagem
// =======================================

class Personagem
{

    // =======================================
    // Atributos
    // =======================================

    private string nome;
    private int vida;
    private int ataque;



    // =======================================
    // Construtor 1
    // Sem parâmetros
    //
    // Define valores padrão
    // =======================================

    public Personagem()
    {
        nome = "Sem nome";

        vida = 100;

        ataque = 10;
    }




    // =======================================
    // Construtor 2
    // Recebe apenas vida
    //
    // Ataque recebe valor padrão
    // =======================================

    public Personagem(int vida)
    {
        nome = "Sem nome";

        this.vida = vida;

        ataque = 10;
    }




    // =======================================
    // Construtor 3
    // Recebe vida e ataque
    // =======================================

    public Personagem(
        int vida,
        int ataque
    )
    {
        nome = "Sem nome";

        this.vida = vida;

        this.ataque = ataque;
    }




    // =======================================
    // Construtor extra
    // Recebe nome, vida e ataque
    // (opcional, mas útil no RPG)
    // =======================================

    public Personagem(
        string nome,
        int vida,
        int ataque
    )
    {
        this.nome = nome;

        this.vida = vida;

        this.ataque = ataque;
    }




    // =======================================
    // Método de ataque individual
    // Recebe apenas um personagem
    // =======================================

    public void Atacar(Personagem inimigo)
    {

        Console.WriteLine(
            $"{nome} atacou {inimigo.nome}"
        );


        inimigo.ReceberDano(ataque);

    }





    // =======================================
    // Método de ataque em lista
    //
    // Recebe vários personagens
    // =======================================

    public void Atacar(List<Personagem> inimigos)
    {


        Console.WriteLine(
            $"\n{nome} atacou vários inimigos!"
        );



        // Percorre todos os inimigos da lista

        foreach(Personagem inimigo in inimigos)
        {

            inimigo.ReceberDano(ataque);

        }

    }





    // =======================================
    // Método que recebe dano
    // =======================================

    public void ReceberDano(int dano)
    {

        vida -= dano;



        // Impede vida negativa

        if(vida < 0)
        {
            vida = 0;
        }



        Console.WriteLine(
            $"{nome} recebeu {dano} de dano. Vida atual: {vida}"
        );

    }





    // =======================================
    // Mostrar informações
    // =======================================

    public void MostrarStatus()
    {

        Console.WriteLine(
            $"Nome: {nome} | Vida: {vida} | Ataque: {ataque}"
        );

    }

}





// =======================================
// Programa principal
// =======================================

class Program
{

    static void Main()
    {


        // =======================================
        // Criando personagens de formas diferentes
        // =======================================


        // Usa construtor sem parâmetros
        // Vida = 100
        // Ataque = 10

        Personagem guerreiro = new Personagem(
            "Arthur",
            100,
            20
        );



        // Usa construtor apenas com vida
        // Vida = 80
        // Ataque = 10

        Personagem mago = new Personagem(80);



        // Usa construtor completo

        Personagem arqueiro = new Personagem(
            "Legolas",
            90,
            15
        );



        Console.WriteLine("===== STATUS INICIAL =====\n");


        guerreiro.MostrarStatus();

        mago.MostrarStatus();

        arqueiro.MostrarStatus();





        // =======================================
        // Ataque contra apenas um personagem
        // =======================================


        Console.WriteLine("\n===== ATAQUE INDIVIDUAL =====");


        guerreiro.Atacar(mago);






        // =======================================
        // Ataque contra uma lista de personagens
        // =======================================


        Console.WriteLine("\n===== ATAQUE EM GRUPO =====");



        List<Personagem> inimigos = new List<Personagem>();


        inimigos.Add(mago);

        inimigos.Add(arqueiro);



        guerreiro.Atacar(inimigos);



        Console.WriteLine("\n===== STATUS FINAL =====");



        guerreiro.MostrarStatus();

        mago.MostrarStatus();

        arqueiro.MostrarStatus();


    }

}