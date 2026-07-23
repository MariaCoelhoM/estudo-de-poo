/*
Uma empresa de pedágios te contratou para fazer um programa que realiza o cálculo de um
pedágio em uma via.
O valor do pedágio se baseia no número de eixos de um veículo. O sistema do pedágio
deve cobrar R$ 10,50 para cada eixo de um veículo. Um veículo possui modelo, placa e
número de eixos. Um carro possui 2 eixos, enquanto um ônibus possui 4 eixos, e um
caminhão possui 5 eixos.
Um pedágio deve atender os veículos a partir de uma fila. Para cada veículo atendido, deve
ser impresso o modelo, a placa e o valor da taxa para o veículo. Ao finalizar a fila de
veículos, deve ser gerado um relatório apresentando a arrecadação total.*/
using System;
class Pedagio
{
    // Atributos
    public string Modelo;
    public string  Placa;
    public int  NumeroEixo;
    public double Total;

    // Método
    public void CalcularEixo()
    {
        if(Modelo == "Carro")
        {
            Console.WriteLine("O seu Carro tem 2 eixos!");
            NumeroEixo = 2;
            Total = NumeroEixo * 10.50;
        }
        else if(Modelo == "Onibus")
        {
            Console.WriteLine("O seu Onibus tem 4 eixos!");
            NumeroEixo = 4;
            Total = NumeroEixo * 10.50;
        }
        else if(Modelo == "Caminhao")
        {
            Console.WriteLine("O seu Caminhao tem 5 eixos!");
            NumeroEixo = 5;
            Total = NumeroEixo * 10.50;
        }
    }
}

class Program : Pedagio
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Pedagio pedagio = new Pedagio();

        Console.WriteLine("Digite o nome do Modelo do seu véiculo: ");
        pedagio.Modelo = Console.ReadLine();

        Console.WriteLine("Digite aqui a sua placa do seu véiculo: ");
        pedagio.Placa = Console.ReadLine();


        Console.WriteLine();
        Console.WriteLine("----------Relatorio:------------");
        Console.WriteLine($"Modelo: {pedagio.Modelo}");
        Console.WriteLine($"Placa: {pedagio.Placa}");
        pedagio.CalcularEixo();
        Console.WriteLine($"Numero do Eixo do véiculo: {pedagio.NumeroEixo}");
        Console.WriteLine($"O total a ser pago é: R${pedagio.Total}");
    }
}