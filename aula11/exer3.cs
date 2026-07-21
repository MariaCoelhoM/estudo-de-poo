/*• Crie um programa que simula produtos eletrônicos
• Um eletrônico pode ligar e desligar
• Existem eletrônicos que necessitam de tomada, e eletrônicos que funcionam a bateria
• Eletrônicos que necessitam de tomada precisam de uma voltagem (110 ou 220)
• Eletrônicos que precisam de bateria possui uma porcentagem de bateria. Só é possível ligar quando a
bateria está acima de 0
• Uma TV é um eletrônico de tomada que pode mudar de canal a partir de um número do canal
• Um computador de mesa é um eletrônico que pode abrir programa a partir de um nome do programa
• Um smartphone é um eletrônico de bateria que pode fazer uma ligação a partir de um número
• Um computador de mesa e um smartphone podem navegar na internet a partir de uma URL*/
using System;


// =======================================
// Classe abstrata Eletronico
// Classe base de todos os eletrônicos
// =======================================

abstract class Eletronico
{

    protected string nome;

    protected bool ligado;



    // Construtor

    public Eletronico(string nome)
    {
        this.nome = nome;

        ligado = false;
    }



    // =======================================
    // Método ligar
    // Será sobrescrito pelas classes filhas
    // =======================================

    public abstract void Ligar();



    // =======================================
    // Método desligar
    // Todo eletrônico pode desligar
    // =======================================

    public virtual void Desligar()
    {

        ligado = false;


        Console.WriteLine(
            $"{nome} foi desligado."
        );

    }

}




// =======================================
// Classe EletronicoTomada
// Eletrônicos que precisam de energia
// =======================================

abstract class EletronicoTomada : Eletronico
{


    protected int voltagem;



    // Construtor

    public EletronicoTomada(
        string nome,
        int voltagem
    )
        : base(nome)
    {

        this.voltagem = voltagem;

    }



    // Método ligar

    public override void Ligar()
    {

        ligado = true;


        Console.WriteLine(
            $"{nome} ligado na tomada {voltagem}V."
        );

    }

}





// =======================================
// Classe EletronicoBateria
// Eletrônicos que usam bateria
// =======================================

abstract class EletronicoBateria : Eletronico
{


    protected int bateria;



    // Construtor

    public EletronicoBateria(
        string nome,
        int bateria
    )
        : base(nome)
    {

        this.bateria = bateria;

    }





    // =======================================
    // Liga somente se bateria > 0
    // =======================================

    public override void Ligar()
    {


        if(bateria > 0)
        {

            ligado = true;


            Console.WriteLine(
                $"{nome} ligado. Bateria: {bateria}%"
            );

        }
        else
        {

            Console.WriteLine(
                $"{nome} não pode ligar. Bateria sem carga."
            );

        }


    }

}





// =======================================
// Interface INavegavel
// Define quem pode acessar internet
// =======================================

interface INavegavel
{

    void NavegarInternet(string url);

}





// =======================================
// Classe TV
// Herda de EletronicoTomada
// =======================================

class TV : EletronicoTomada
{


    private int canal;



    public TV(
        string nome,
        int voltagem
    )
        : base(nome, voltagem)
    {

        canal = 1;

    }





    // Trocar canal

    public void MudarCanal(int novoCanal)
    {

        canal = novoCanal;


        Console.WriteLine(
            $"{nome} mudou para o canal {canal}."
        );

    }

}





// =======================================
// Classe ComputadorMesa
// Herda de tomada
// Implementa internet
// =======================================

class ComputadorMesa : EletronicoTomada, INavegavel
{


    public ComputadorMesa(
        string nome,
        int voltagem
    )
        : base(nome, voltagem)
    {

    }





    // Abrir programa

    public void AbrirPrograma(string programa)
    {

        Console.WriteLine(
            $"{nome} abriu o programa {programa}."
        );

    }





    // Navegar internet

    public void NavegarInternet(string url)
    {

        Console.WriteLine(
            $"{nome} acessou {url}."
        );

    }

}





// =======================================
// Classe Smartphone
// Herda de bateria
// Implementa internet
// =======================================

class Smartphone : EletronicoBateria, INavegavel
{


    public Smartphone(
        string nome,
        int bateria
    )
        : base(nome, bateria)
    {

    }





    // Fazer ligação

    public void FazerLigacao(string numero)
    {

        if(ligado)
        {

            Console.WriteLine(
                $"{nome} ligando para {numero}."
            );

        }
        else
        {

            Console.WriteLine(
                $"{nome} está desligado."
            );

        }

    }





    // Navegar internet

    public void NavegarInternet(string url)
    {

        if(ligado)
        {

            Console.WriteLine(
                $"{nome} acessou {url}."
            );

        }

    }

}





// =======================================
// Programa principal
// =======================================

class Program
{

    static void Main()
    {


        // Criando uma TV

        TV tv = new TV(
            "Smart TV Samsung",
            220
        );



        // Criando computador

        ComputadorMesa computador =
            new ComputadorMesa(
                "PC Gamer",
                110
            );



        // Criando smartphone

        Smartphone celular =
            new Smartphone(
                "iPhone",
                80
            );




        Console.WriteLine(
            "===== ELETRÔNICOS =====\n"
        );



        // Ligando dispositivos

        tv.Ligar();

        computador.Ligar();

        celular.Ligar();




        Console.WriteLine();



        // Funções específicas

        tv.MudarCanal(5);



        computador.AbrirPrograma(
            "Visual Studio"
        );


        computador.NavegarInternet(
            "https://github.com"
        );



        celular.FazerLigacao(
            "11999999999"
        );


        celular.NavegarInternet(
            "https://google.com"
        );




        Console.WriteLine();



        // Desligando

        tv.Desligar();

        computador.Desligar();

        celular.Desligar();


    }

}