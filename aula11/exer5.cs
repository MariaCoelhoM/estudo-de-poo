/*• Crie uma classe Veiculo abstrata, que tenham os métodos Ligar e Desligar, e os atributos
velocidadeAtual e estaLigado;
• Só é possível desligar o veículo com ele ligado e com velocidade 0, e ligar com ele desligado e
velocidade 0
• Crie a classe abstrata VeiculoTerrestre, que tem os métodos Acelerar e Freiar
• Crie a classe abstrata VeiculoVoador, que tem os métodos Voar e Pousar e o atributo estaVoando.
Sobrescreva o método de Ligar e Desligar para garantir que seja possível ligar e desligar somente
quando o veículo estiver pousado
• Crie a interface IBuzinavel, que possui um método chamado Buzinar
• Crie as classes Carro e Caminhao, que herdam de VeiculoTerrestre, e Aviao e Helicoptero, que
herdam de VeiculoVoador. Faça todas implementarem IBuzinavel.*/
using System;


// =======================================
// Classe abstrata Veiculo
// Classe base de todos os veículos
// =======================================

abstract class Veiculo
{

    // Velocidade atual do veículo

    protected int velocidadeAtual;



    // Indica se o veículo está ligado

    protected bool estaLigado;



    // Construtor

    public Veiculo()
    {
        velocidadeAtual = 0;

        estaLigado = false;
    }




    // =======================================
    // Método abstrato Ligar
    // Cada veículo implementa sua regra
    // =======================================

    public abstract void Ligar();





    // =======================================
    // Método virtual Desligar
    //
    // Só pode desligar se:
    // - estiver ligado
    // - velocidade for 0
    // =======================================

    public virtual void Desligar()
    {

        if(estaLigado && velocidadeAtual == 0)
        {

            estaLigado = false;


            Console.WriteLine(
                "Veículo desligado."
            );

        }
        else
        {

            Console.WriteLine(
                "Não é possível desligar."
            );

        }

    }

}







// =======================================
// Classe abstrata VeiculoTerrestre
// Veículos que andam no solo
// =======================================

abstract class VeiculoTerrestre : Veiculo
{


    // =======================================
    // Método acelerar
    // =======================================

    public void Acelerar(int valor)
    {

        if(estaLigado)
        {

            velocidadeAtual += valor;


            Console.WriteLine(
                $"Velocidade: {velocidadeAtual} km/h"
            );

        }
        else
        {

            Console.WriteLine(
                "Veículo desligado."
            );

        }

    }





    // =======================================
    // Método freiar
    // =======================================

    public void Freiar(int valor)
    {

        velocidadeAtual -= valor;



        if(velocidadeAtual < 0)
        {
            velocidadeAtual = 0;
        }



        Console.WriteLine(
            $"Velocidade: {velocidadeAtual} km/h"
        );

    }

}







// =======================================
// Classe abstrata VeiculoVoador
// =======================================

abstract class VeiculoVoador : Veiculo
{


    // Indica se está voando

    protected bool estaVoando;




    public VeiculoVoador()
    {

        estaVoando = false;

    }




    // =======================================
    // Ligar sobrescrito
    //
    // Só liga se estiver pousado
    // =======================================

    public override void Ligar()
    {

        if(!estaVoando && !estaLigado && velocidadeAtual == 0)
        {

            estaLigado = true;


            Console.WriteLine(
                "Veículo voador ligado."
            );

        }
        else
        {

            Console.WriteLine(
                "Não foi possível ligar."
            );

        }

    }




    // =======================================
    // Desligar sobrescrito
    //
    // Só desliga se estiver pousado
    // =======================================

    public override void Desligar()
    {

        if(!estaVoando && estaLigado)
        {

            estaLigado = false;


            Console.WriteLine(
                "Veículo voador desligado."
            );

        }
        else
        {

            Console.WriteLine(
                "Não pode desligar voando."
            );

        }

    }





    // =======================================
    // Voar
    // =======================================

    public void Voar()
    {

        if(estaLigado)
        {

            estaVoando = true;


            Console.WriteLine(
                "Veículo começou a voar."
            );

        }
        else
        {

            Console.WriteLine(
                "Veículo desligado."
            );

        }

    }





    // =======================================
    // Pousar
    // =======================================

    public void Pousar()
    {

        estaVoando = false;


        velocidadeAtual = 0;


        Console.WriteLine(
            "Veículo pousou."
        );

    }

}







// =======================================
// Interface IBuzinavel
// =======================================

interface IBuzinavel
{

    void Buzinar();

}







// =======================================
// Classe Carro
// Herda de VeiculoTerrestre
// Implementa buzina
// =======================================

class Carro : VeiculoTerrestre, IBuzinavel
{


    public override void Ligar()
    {

        if(!estaLigado && velocidadeAtual == 0)
        {

            estaLigado = true;


            Console.WriteLine(
                "Carro ligado."
            );

        }

    }





    public void Buzinar()
    {

        Console.WriteLine(
            "Bii Bii!"
        );

    }

}







// =======================================
// Classe Caminhao
// =======================================

class Caminhao : VeiculoTerrestre, IBuzinavel
{


    public override void Ligar()
    {

        if(!estaLigado && velocidadeAtual == 0)
        {

            estaLigado = true;


            Console.WriteLine(
                "Caminhão ligado."
            );

        }

    }




    public void Buzinar()
    {

        Console.WriteLine(
            "Fom Fom!"
        );

    }

}







// =======================================
// Classe Aviao
// =======================================

class Aviao : VeiculoVoador, IBuzinavel
{


    public void Buzinar()
    {

        Console.WriteLine(
            "Buzina do avião!"
        );

    }

}







// =======================================
// Classe Helicoptero
// =======================================

class Helicoptero : VeiculoVoador, IBuzinavel
{


    public void Buzinar()
    {

        Console.WriteLine(
            "Buzina do helicóptero!"
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


        // Criando veículos

        Carro carro = new Carro();


        Caminhao caminhao = new Caminhao();


        Aviao aviao = new Aviao();


        Helicoptero helicoptero = new Helicoptero();




        Console.WriteLine(
            "===== CARRO ====="
        );


        carro.Ligar();


        carro.Acelerar(50);


        carro.Freiar(50);


        carro.Desligar();


        carro.Buzinar();





        Console.WriteLine(
            "\n===== AVIÃO ====="
        );


        aviao.Ligar();


        aviao.Voar();


        aviao.Pousar();


        aviao.Desligar();


        aviao.Buzinar();





        Console.WriteLine(
            "\n===== HELICÓPTERO ====="
        );


        helicoptero.Ligar();


        helicoptero.Voar();


        helicoptero.Desligar(); // Não permite voando


        helicoptero.Pousar();


        helicoptero.Desligar();


        helicoptero.Buzinar();

    }

}