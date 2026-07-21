/*• Crie a classe abstrata Jogador, que possui o método abstrato Jogar
• Crie a interface IChutador, que possui o método ChutarBola
• Crie a interface IArremessador, que possui o método ArremessarBola
• Crie a interface IPassador, que possui o método PassarBola
• Crie as classes JogadorFutebol, JogadorBoliche e JogadorBasquete
• JogadorFutebol deve implementar IChutador e IPassador
• JogadorBoliche deve implementar IArremessador
• Jogador Basquete deve implementar IPassador e IArremessador
• Implemente o método Jogar executando os métodos das interfaces
• Crie instâncias de Jogadores, adicione em uma lista e execute os métodos Jogar*/
using System;
using System.Collections.Generic;


// =======================================
// Classe abstrata Jogador
// =======================================

// Todos os jogadores terão que possuir
// o método Jogar(), mas cada um terá
// sua própria implementação.

abstract class Jogador
{

    protected string nome;



    // Construtor

    public Jogador(string nome)
    {
        this.nome = nome;
    }



    // Método abstrato
    // Toda classe filha é obrigada
    // a implementar.

    public abstract void Jogar();

}





// =======================================
// Interface IChutador
// Define a habilidade de chutar
// =======================================

interface IChutador
{

    void ChutarBola();

}





// =======================================
// Interface IArremessador
// Define a habilidade de arremessar
// =======================================

interface IArremessador
{

    void ArremessarBola();

}





// =======================================
// Interface IPassador
// Define a habilidade de passar bola
// =======================================

interface IPassador
{

    void PassarBola();

}





// =======================================
// Classe JogadorFutebol
// Herda de Jogador
// Implementa duas interfaces
// =======================================

class JogadorFutebol : Jogador, IChutador, IPassador
{


    public JogadorFutebol(string nome)
        : base(nome)
    {

    }




    // Implementação do método abstrato

    public override void Jogar()
    {

        Console.WriteLine(
            $"\n{nome} está jogando futebol!"
        );


        // Executa os métodos das interfaces

        ChutarBola();

        PassarBola();

    }




    // Implementação da interface IChutador

    public void ChutarBola()
    {
        Console.WriteLine(
            $"{nome} chutou a bola."
        );
    }




    // Implementação da interface IPassador

    public void PassarBola()
    {
        Console.WriteLine(
            $"{nome} passou a bola."
        );
    }

}





// =======================================
// Classe JogadorBoliche
// Herda de Jogador
// Implementa IArremessador
// =======================================

class JogadorBoliche : Jogador, IArremessador
{


    public JogadorBoliche(string nome)
        : base(nome)
    {

    }




    // Implementação do método Jogar

    public override void Jogar()
    {

        Console.WriteLine(
            $"\n{nome} está jogando boliche!"
        );


        // Executa habilidade

        ArremessarBola();

    }




    // Implementação da interface

    public void ArremessarBola()
    {

        Console.WriteLine(
            $"{nome} arremessou a bola no boliche."
        );

    }

}





// =======================================
// Classe JogadorBasquete
// Herda de Jogador
// Implementa duas interfaces
// =======================================

class JogadorBasquete : Jogador, IPassador, IArremessador
{


    public JogadorBasquete(string nome)
        : base(nome)
    {

    }




    // Implementação do método Jogar

    public override void Jogar()
    {

        Console.WriteLine(
            $"\n{nome} está jogando basquete!"
        );


        // Executa habilidades

        PassarBola();

        ArremessarBola();

    }




    // Implementação da interface IPassador

    public void PassarBola()
    {

        Console.WriteLine(
            $"{nome} passou a bola no basquete."
        );

    }




    // Implementação da interface IArremessador

    public void ArremessarBola()
    {

        Console.WriteLine(
            $"{nome} fez um arremesso."
        );

    }

}





// =======================================
// Classe Program
// =======================================

class Program
{

    static void Main()
    {


        // =======================================
        // Criando uma lista de Jogadores
        // =======================================

        // A lista aceita qualquer classe
        // que herde de Jogador.

        List<Jogador> jogadores = new List<Jogador>();




        // Criando jogadores

        JogadorFutebol jogadorFutebol =
            new JogadorFutebol("Neymar");



        JogadorBoliche jogadorBoliche =
            new JogadorBoliche("João");



        JogadorBasquete jogadorBasquete =
            new JogadorBasquete("LeBron");





        // Adicionando jogadores na lista

        jogadores.Add(jogadorFutebol);

        jogadores.Add(jogadorBoliche);

        jogadores.Add(jogadorBasquete);





        Console.WriteLine(
            "===== PARTIDA ====="
        );




        // Percorre todos os jogadores

        foreach(Jogador jogador in jogadores)
        {


            // Polimorfismo:
            //
            // Cada jogador executa
            // sua própria versão de Jogar()

            jogador.Jogar();

        }



    }

}