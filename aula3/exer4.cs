/*• Usando o exercício 3, adicione a possibilidade de mudar de marcha no carro
• Um carro comum só pode ter 5 marchas (vamos ignorar a ré)
• a cada 20 Km/h em sua velocidade, deve ser avisado que é necessário
mudar de marcha
• Deve ser necessário avançar de marcha progressivamente (só deve ser
possível ir da 1 para a 2, e nunca da 1 para a 3, por exemplo)
• Reflita sobre as possibilidades e limites do programa, além das
responsabilidades de métodos e classes*/
using System;

// Classe Carro
class Carro
{
    // Atributos do carro
    public string Modelo;
    public string Cor;
    public string Placa;

    // Velocidade atual
    public int Velocidade = 0;

    // Quanto o carro acelera por vez
    public int Aceleracao;

    // Marcha atual (começa na primeira)
    public int Marcha = 1;

    // Método para acelerar
    public void Acelerar()
    {
        // Aumenta a velocidade
        Velocidade += Aceleracao;

        Console.WriteLine($"{Modelo} acelerou para {Velocidade} Km/h");

        // Verifica se precisa trocar de marcha
        if (Velocidade >= Marcha * 20 && Marcha < 5)
        {
            Console.WriteLine(">>> Atenção: é recomendado trocar para a próxima marcha!");
        }

        // Verifica se levou multa
        if (Velocidade > 80)
        {
            int excesso = Velocidade - 80;
            int multa = excesso * 5;

            Console.WriteLine("\n***** MULTA *****");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Excesso: {excesso} Km/h");
            Console.WriteLine($"Valor da multa: R$ {multa}");
        }
    }

    // Método para frear
    public void Frear()
    {
        Velocidade -= 10;

        // Não permite velocidade negativa
        if (Velocidade < 0)
        {
            Velocidade = 0;
        }

        Console.WriteLine($"{Modelo} reduziu para {Velocidade} Km/h");
    }

    // Método para subir marcha
    public void SubirMarcha()
    {
        if (Marcha < 5)
        {
            Marcha++;
            Console.WriteLine($"Marcha alterada para {Marcha}ª.");
        }
        else
        {
            Console.WriteLine("O carro já está na última marcha.");
        }
    }

    // Método para reduzir marcha
    public void ReduzirMarcha()
    {
        if (Marcha > 1)
        {
            Marcha--;
            Console.WriteLine($"Marcha alterada para {Marcha}ª.");
        }
        else
        {
            Console.WriteLine("O carro já está na primeira marcha.");
        }
    }

    // Exibe as informações do carro
    public void MostrarStatus()
    {
        Console.WriteLine("\n===== STATUS =====");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Placa: {Placa}");
        Console.WriteLine($"Velocidade: {Velocidade} Km/h");
        Console.WriteLine($"Marcha: {Marcha}ª");
    }
}

class Program
{
    static void Main()
    {
        // Cria um carro
        Carro carro = new Carro();

        carro.Modelo = "Civic";
        carro.Cor = "Prata";
        carro.Placa = "ABC-1234";
        carro.Aceleracao = 20;

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Acelerar");
            Console.WriteLine("2 - Frear");
            Console.WriteLine("3 - Subir marcha");
            Console.WriteLine("4 - Reduzir marcha");
            Console.WriteLine("5 - Mostrar status");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    carro.Acelerar();
                    break;

                case 2:
                    carro.Frear();
                    break;

                case 3:
                    carro.SubirMarcha();
                    break;

                case 4:
                    carro.ReduzirMarcha();
                    break;

                case 5:
                    carro.MostrarStatus();
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