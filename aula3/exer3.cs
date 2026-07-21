/*Faça um programa que simula a movimentação de um carro.
Toda vez que o carro acelerar, aumente sua velocidade
Toda vez que o carro frear, diminua sua velocidade
Crie diferentes tipos de instâncias de carros
Os carros devem acelerar em velocidades diferentes
Se um carro ultrapassar o limite de 80 Km/h, deve ser impresso uma multa
de R$ 5 para cada km excedido, apresentando a placa do carro, o modelo, e
sua cor*/
using System;

// Classe Carro
class Carro
{
    // Atributos do carro
    public string Modelo;
    public string Cor;
    public string Placa;
    public int Velocidade;

    // Quanto esse carro acelera por vez
    public int Aceleracao;

    // Método para acelerar
    public void Acelerar()
    {
        Velocidade += Aceleracao;

        Console.WriteLine($"{Modelo} acelerou para {Velocidade} Km/h");

        // Verifica se ultrapassou o limite
        if (Velocidade > 80)
        {
            int excesso = Velocidade - 80;
            int multa = excesso * 5;

            Console.WriteLine("******** MULTA ********");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Excesso: {excesso} Km/h");
            Console.WriteLine($"Valor da multa: R$ {multa}");
            Console.WriteLine();
        }
    }

    // Método para frear
    public void Frear()
    {
        Velocidade -= 10;

        // Impede velocidade negativa
        if (Velocidade < 0)
        {
            Velocidade = 0;
        }

        Console.WriteLine($"{Modelo} reduziu para {Velocidade} Km/h");
    }
}

class Program
{
    static void Main()
    {
        // Criando três carros
        Carro carro1 = new Carro();
        carro1.Modelo = "Corolla";
        carro1.Cor = "Preto";
        carro1.Placa = "ABC-1234";
        carro1.Aceleracao = 10;

        Carro carro2 = new Carro();
        carro2.Modelo = "Ferrari";
        carro2.Cor = "Vermelha";
        carro2.Placa = "XYZ-5678";
        carro2.Aceleracao = 30;

        Carro carro3 = new Carro();
        carro3.Modelo = "Civic";
        carro3.Cor = "Branco";
        carro3.Placa = "DEF-9876";
        carro3.Aceleracao = 20;

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Acelerar Corolla");
            Console.WriteLine("2 - Frear Corolla");
            Console.WriteLine("3 - Acelerar Ferrari");
            Console.WriteLine("4 - Frear Ferrari");
            Console.WriteLine("5 - Acelerar Civic");
            Console.WriteLine("6 - Frear Civic");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    carro1.Acelerar();
                    break;

                case 2:
                    carro1.Frear();
                    break;

                case 3:
                    carro2.Acelerar();
                    break;

                case 4:
                    carro2.Frear();
                    break;

                case 5:
                    carro3.Acelerar();
                    break;

                case 6:
                    carro3.Frear();
                    break;

                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }
}