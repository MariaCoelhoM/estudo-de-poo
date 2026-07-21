/*• Usando o sistema de RPG feito na aula passada:
• Faça um sistema de Equipamento. Um Personagem pode dois equipamentos.
• Faça uma classe para Arma e outro para Escudo. Uma Arma possui um dano, e um
Escudo possui resistencia
• Crie uma Espada, um Arco e um Cajado que herdam de Arma. Cada um possui
diferentes tipos de ataque.
• Crie interfaces para IEspadaEquipavel, IArcoEquipavel, ICajadoEquipavel e
IEscudoEquipavel, com o método equipar que equipe cada uma das armas ou escudo
• Um Guerreiro pode usar espadas e escudos, enquanto um Arqueiro só pode usar
apenas 1 arco, e um Mago apenas 1 cajado e 1 escudo*/
using System;
using System.Collections.Generic;


// =======================================
// Classe Equipamento
// Classe base para todos equipamentos
// =======================================

abstract class Equipamento
{

    protected string nome;


    public Equipamento(string nome)
    {
        this.nome = nome;
    }


    public string GetNome()
    {
        return nome;
    }

}







// =======================================
// Classe Arma
// Herda de Equipamento
// =======================================

abstract class Arma : Equipamento
{

    protected int dano;



    public Arma(
        string nome,
        int dano
    )
        : base(nome)
    {
        this.dano = dano;
    }



    public int GetDano()
    {
        return dano;
    }




    // Cada arma terá seu próprio ataque

    public abstract void Atacar();

}







// =======================================
// Classe Escudo
// =======================================

class Escudo : Equipamento
{

    private int resistencia;



    public Escudo(
        string nome,
        int resistencia
    )
        : base(nome)
    {
        this.resistencia = resistencia;
    }



    public int GetResistencia()
    {
        return resistencia;
    }

}







// =======================================
// Classes de armas específicas
// =======================================


// -------- ESPADA --------

class Espada : Arma
{


    public Espada()
        : base("Espada", 30)
    {

    }




    public override void Atacar()
    {
        Console.WriteLine(
            "Ataque de espada: golpe cortante!"
        );
    }

}







// -------- ARCO --------

class Arco : Arma
{


    public Arco()
        : base("Arco", 20)
    {

    }




    public override void Atacar()
    {
        Console.WriteLine(
            "Ataque de arco: flecha disparada!"
        );
    }

}







// -------- CAJADO --------

class Cajado : Arma
{


    public Cajado()
        : base("Cajado", 40)
    {

    }




    public override void Atacar()
    {
        Console.WriteLine(
            "Ataque de cajado: magia lançada!"
        );
    }

}








// =======================================
// Interfaces de equipamentos
// =======================================


interface IEspadaEquipavel
{

    void Equipar(Espada espada);

}



interface IArcoEquipavel
{

    void Equipar(Arco arco);

}



interface ICajadoEquipavel
{

    void Equipar(Cajado cajado);

}



interface IEscudoEquipavel
{

    void Equipar(Escudo escudo);

}







// =======================================
// Classe Personagem
// Todo personagem pode ter 2 equipamentos
// =======================================

abstract class Personagem
{

    protected string nome;


    // Dois espaços de equipamento

    protected Equipamento equipamento1;

    protected Equipamento equipamento2;




    public Personagem(string nome)
    {
        this.nome = nome;
    }




    public void MostrarEquipamentos()
    {

        Console.WriteLine(
            $"\nEquipamentos de {nome}:"
        );


        if(equipamento1 != null)
        {
            Console.WriteLine(
                equipamento1.GetNome()
            );
        }


        if(equipamento2 != null)
        {
            Console.WriteLine(
                equipamento2.GetNome()
            );
        }

    }

}








// =======================================
// Guerreiro
//
// Pode usar:
// - Espada
// - Escudo
// =======================================

class Guerreiro : Personagem, IEspadaEquipavel, IEscudoEquipavel
{


    public Guerreiro(string nome)
        : base(nome)
    {

    }




    public void Equipar(Espada espada)
    {

        equipamento1 = espada;


        Console.WriteLine(
            $"{nome} equipou uma espada."
        );

    }





    public void Equipar(Escudo escudo)
    {

        equipamento2 = escudo;


        Console.WriteLine(
            $"{nome} equipou um escudo."
        );

    }

}








// =======================================
// Arqueiro
//
// Pode usar apenas arco
// =======================================

class Arqueiro : Personagem, IArcoEquipavel
{


    public Arqueiro(string nome)
        : base(nome)
    {

    }




    public void Equipar(Arco arco)
    {

        equipamento1 = arco;


        Console.WriteLine(
            $"{nome} equipou um arco."
        );

    }

}








// =======================================
// Mago
//
// Pode usar:
// - Cajado
// - Escudo
// =======================================

class Mago : Personagem, ICajadoEquipavel, IEscudoEquipavel
{


    public Mago(string nome)
        : base(nome)
    {

    }




    public void Equipar(Cajado cajado)
    {

        equipamento1 = cajado;


        Console.WriteLine(
            $"{nome} equipou um cajado."
        );

    }





    public void Equipar(Escudo escudo)
    {

        equipamento2 = escudo;


        Console.WriteLine(
            $"{nome} equipou um escudo."
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


        // Criando equipamentos

        Espada espada = new Espada();


        Arco arco = new Arco();


        Cajado cajado = new Cajado();


        Escudo escudo = new Escudo(
            "Escudo de Ferro",
            50
        );





        // Criando personagens

        Guerreiro guerreiro =
            new Guerreiro("Arthur");


        Arqueiro arqueiro =
            new Arqueiro("Legolas");


        Mago mago =
            new Mago("Gandalf");





        Console.WriteLine(
            "===== EQUIPANDO ====="
        );



        // Guerreiro usa espada e escudo

        guerreiro.Equipar(espada);

        guerreiro.Equipar(escudo);




        // Arqueiro usa apenas arco

        arqueiro.Equipar(arco);




        // Mago usa cajado e escudo

        mago.Equipar(cajado);

        mago.Equipar(escudo);






        // Mostrar equipamentos

        guerreiro.MostrarEquipamentos();


        arqueiro.MostrarEquipamentos();


        mago.MostrarEquipamentos();





        Console.WriteLine(
            "\n===== ATAQUES ====="
        );



        espada.Atacar();


        arco.Atacar();


        cajado.Atacar();



    }

}