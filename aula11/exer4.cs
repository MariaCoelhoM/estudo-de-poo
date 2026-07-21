/*• Refatore o código do Exercício 2 para incluir um Notebook
• Um Notebook é um computador, que também é um eletrônico de bateria, e que também
pode navegar na internet
• Crie, também, a classe Carregador
• A classe carregador possui o método Carregar, que carrega a bateria de eletrônicos que
funcionam a bateria*/
using System;


// =======================================
// Classe abstrata Eletronico
// Classe base de todos os eletrônicos
// =======================================

abstract class Eletronico
{

    protected string nome;

    protected bool ligado;



    public Eletronico(string nome)
    {
        this.nome = nome;

        ligado = false;
    }




    // Todo eletrônico pode ligar

    public abstract void Ligar();




    // Todo eletrônico pode desligar

    public virtual void Desligar()
    {

        ligado = false;


        Console.WriteLine(
            $"{nome} desligado."
        );

    }

}







// =======================================
// Eletrônicos que funcionam na tomada
// =======================================

abstract class EletronicoTomada : Eletronico
{

    protected int voltagem;



    public EletronicoTomada(
        string nome,
        int voltagem
    )
        : base(nome)
    {

        this.voltagem = voltagem;

    }




    public override void Ligar()
    {

        ligado = true;


        Console.WriteLine(
            $"{nome} ligado na tomada {voltagem}V."
        );

    }

}







// =======================================
// Eletrônicos que funcionam com bateria
// =======================================

abstract class EletronicoBateria : Eletronico
{


    protected int bateria;



    public EletronicoBateria(
        string nome,
        int bateria
    )
        : base(nome)
    {

        this.bateria = bateria;

    }




    // Só liga se tiver bateria

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
                $"{nome} sem bateria."
            );

        }

    }




    // Método usado pelo carregador

    public void CarregarBateria(int valor)
    {

        bateria += valor;



        if(bateria > 100)
        {
            bateria = 100;
        }



        Console.WriteLine(
            $"{nome} carregou. Bateria atual: {bateria}%"
        );

    }

}







// =======================================
// Interface para internet
// =======================================

interface INavegavel
{

    void NavegarInternet(string url);

}







// =======================================
// Computador de mesa
// É eletrônico de tomada
// =======================================

class ComputadorMesa : EletronicoTomada
{


    public ComputadorMesa(
        string nome,
        int voltagem
    )
        : base(nome, voltagem)
    {

    }




    public void AbrirPrograma(string programa)
    {

        Console.WriteLine(
            $"{nome} abriu {programa}."
        );

    }




    public void NavegarInternet(string url)
    {

        Console.WriteLine(
            $"{nome} acessou {url}."
        );

    }

}







// =======================================
// Smartphone
// É eletrônico de bateria
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




    public void FazerLigacao(string numero)
    {

        if(ligado)
        {

            Console.WriteLine(
                $"{nome} ligando para {numero}."
            );

        }

    }




    public void NavegarInternet(string url)
    {

        Console.WriteLine(
            $"{nome} acessou {url}."
        );

    }

}







// =======================================
// NOVA CLASSE NOTEBOOK
//
// Notebook:
// - é computador
// - usa bateria
// - acessa internet
//
// Como C# não permite herança múltipla,
// ele herda de EletronicoBateria e
// implementa INavegavel.
// =======================================

class Notebook : EletronicoBateria, INavegavel
{


    public Notebook(
        string nome,
        int bateria
    )
        : base(nome, bateria)
    {

    }





    // Função de computador

    public void AbrirPrograma(string programa)
    {

        Console.WriteLine(
            $"{nome} abriu o programa {programa}."
        );

    }





    // Função de internet

    public void NavegarInternet(string url)
    {

        Console.WriteLine(
            $"{nome} acessou {url}."
        );

    }

}







// =======================================
// Classe Carregador
//
// Responsável por carregar aparelhos
// que possuem bateria
// =======================================

class Carregador
{


    private int carga;



    public Carregador(int carga)
    {
        this.carga = carga;
    }





    // Recebe qualquer eletrônico de bateria

    public void Carregar(EletronicoBateria aparelho)
    {

        Console.WriteLine(
            "\nConectando carregador..."
        );



        aparelho.CarregarBateria(carga);

    }

}







// =======================================
// Programa principal
// =======================================

class Program
{

    static void Main()
    {


        // Criando dispositivos


        Smartphone celular =
            new Smartphone(
                "iPhone",
                30
            );



        Notebook notebook =
            new Notebook(
                "Notebook Dell",
                20
            );



        ComputadorMesa computador =
            new ComputadorMesa(
                "PC Gamer",
                220
            );





        // Criando carregador

        Carregador carregador =
            new Carregador(50);





        Console.WriteLine(
            "===== LIGANDO DISPOSITIVOS =====\n"
        );


        celular.Ligar();

        notebook.Ligar();

        computador.Ligar();





        Console.WriteLine(
            "\n===== USANDO DISPOSITIVOS =====\n"
        );



        notebook.AbrirPrograma(
            "Visual Studio"
        );



        notebook.NavegarInternet(
            "https://github.com"
        );



        celular.FazerLigacao(
            "11999999999"
        );





        Console.WriteLine(
            "\n===== CARREGANDO ====="
        );



        carregador.Carregar(celular);


        carregador.Carregar(notebook);





        Console.WriteLine(
            "\n===== DESLIGANDO ====="
        );


        celular.Desligar();

        notebook.Desligar();

        computador.Desligar();


    }

}