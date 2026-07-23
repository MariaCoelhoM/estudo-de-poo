/*Uma empresa de fabricação de elevadores está procurando por alguém para desenvolver o
sistema de seus elevadores, e te contratou para fazer esse serviço.
Um elevador deve abrir ou fechar a porta, tal qual como subir ou descer um andar. Não
deve ser possível abrir a porta se a porta já estiver aberta, tal qual como não deve ser
possível fechar a porta se ela já estiver fechada. Da mesma forma, só é possível locomover
um elevador de andar por andar, e não deve ser possível descer mais que o limite de
andares do prédio, tal qual como não deve ser possível subir mais que o limite de andares
do prédio.
Um prédio deve ter um determinado número de andares. Em cada andar, pode ou não
existir uma pessoa desejando ir para outro andar. Uma pessoa só deve conseguir entrar em
um elevador se as portas estiverem abertas. Da mesma forma, o elevador só pode se
locomover se estiver com as portas fechadas.
Uma pessoa possui um peso específico. Um elevador não pode se locomover se tiver
excedido o peso máximo de pessoas dentro dele.*/
using System;
using System.Collections.Generic;

// Classe que representa uma pessoa
class Pessoa
{
    // Atributos
    public string Nome;
    public double Peso;
    public int AndarDestino;
}

// Classe que representa o elevador
class Elevador
{
    // Atributos
    public bool PortaAberta = false;
    public int AndarAtual = 0;
    public int TotalAndares;
    public double PesoMaximo;

    // Lista de pessoas dentro do elevador
    public List<Pessoa> Pessoas = new List<Pessoa>();

    // Abre a porta
    public void AbrirPorta()
    {
        if (PortaAberta)
        {
            Console.WriteLine("A porta já está aberta!");
        }
        else
        {
            PortaAberta = true;
            Console.WriteLine("Porta aberta.");
        }
    }

    // Fecha a porta
    public void FecharPorta()
    {
        if (!PortaAberta)
        {
            Console.WriteLine("A porta já está fechada!");
        }
        else
        {
            PortaAberta = false;
            Console.WriteLine("Porta fechada.");
        }
    }

    // Calcula o peso atual
    public double PesoAtual()
    {
        double peso = 0;

        foreach (Pessoa pessoa in Pessoas)
        {
            peso += pessoa.Peso;
        }

        return peso;
    }

    // Entrar no elevador
    public void EntrarPessoa(Pessoa pessoa)
    {
        if (!PortaAberta)
        {
            Console.WriteLine("Abra a porta primeiro!");
            return;
        }

        Pessoas.Add(pessoa);
        Console.WriteLine($"{pessoa.Nome} entrou no elevador.");
    }

    // Sair do elevador
    public void SairPessoa(string nome)
    {
        if (!PortaAberta)
        {
            Console.WriteLine("Abra a porta primeiro!");
            return;
        }

        foreach (Pessoa pessoa in Pessoas)
        {
            if (pessoa.Nome.ToLower() == nome.ToLower())
            {
                Pessoas.Remove(pessoa);
                Console.WriteLine($"{pessoa.Nome} saiu do elevador.");
                return;
            }
        }

        Console.WriteLine("Pessoa não encontrada.");
    }

    // Subir um andar
    public void Subir()
    {
        if (PortaAberta)
        {
            Console.WriteLine("Feche a porta antes de subir.");
            return;
        }

        if (PesoAtual() > PesoMaximo)
        {
            Console.WriteLine("Peso máximo excedido!");
            return;
        }

        if (AndarAtual == TotalAndares)
        {
            Console.WriteLine("O elevador já está no último andar.");
            return;
        }

        AndarAtual++;
        Console.WriteLine($"Elevador subiu para o andar {AndarAtual}.");
    }

    // Descer um andar
    public void Descer()
    {
        if (PortaAberta)
        {
            Console.WriteLine("Feche a porta antes de descer.");
            return;
        }

        if (PesoAtual() > PesoMaximo)
        {
            Console.WriteLine("Peso máximo excedido!");
            return;
        }

        if (AndarAtual == 0)
        {
            Console.WriteLine("O elevador já está no térreo.");
            return;
        }

        AndarAtual--;
        Console.WriteLine($"Elevador desceu para o andar {AndarAtual}.");
    }

    // Mostra informações do elevador
    public void Status()
    {
        Console.WriteLine();
        Console.WriteLine("====== STATUS DO ELEVADOR ======");
        Console.WriteLine($"Andar atual: {AndarAtual}");

        if (PortaAberta)
            Console.WriteLine("Porta: Aberta");
        else
            Console.WriteLine("Porta: Fechada");

        Console.WriteLine($"Pessoas: {Pessoas.Count}");
        Console.WriteLine($"Peso atual: {PesoAtual()} kg");
        Console.WriteLine($"Peso máximo: {PesoMaximo} kg");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Elevador elevador = new Elevador();

        Console.Write("Quantidade de andares do prédio: ");
        elevador.TotalAndares = int.Parse(Console.ReadLine());

        Console.Write("Peso máximo do elevador: ");
        elevador.PesoMaximo = double.Parse(Console.ReadLine());

        int opcao;

        do
        {
            Console.WriteLine();
            Console.WriteLine("======= ELEVADOR =======");
            Console.WriteLine("1 - Abrir porta");
            Console.WriteLine("2 - Fechar porta");
            Console.WriteLine("3 - Subir");
            Console.WriteLine("4 - Descer");
            Console.WriteLine("5 - Entrar pessoa");
            Console.WriteLine("6 - Sair pessoa");
            Console.WriteLine("7 - Status");
            Console.WriteLine("8 - Encerrar");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                elevador.AbrirPorta();
            }

            else if (opcao == 2)
            {
                elevador.FecharPorta();
            }

            else if (opcao == 3)
            {
                elevador.Subir();
            }

            else if (opcao == 4)
            {
                elevador.Descer();
            }

            else if (opcao == 5)
            {
                Pessoa pessoa = new Pessoa();

                Console.Write("Nome: ");
                pessoa.Nome = Console.ReadLine();

                Console.Write("Peso: ");
                pessoa.Peso = double.Parse(Console.ReadLine());

                Console.Write("Andar de destino: ");
                pessoa.AndarDestino = int.Parse(Console.ReadLine());

                elevador.EntrarPessoa(pessoa);
            }

            else if (opcao == 6)
            {
                Console.Write("Nome da pessoa: ");
                string nome = Console.ReadLine();

                elevador.SairPessoa(nome);
            }

            else if (opcao == 7)
            {
                elevador.Status();
            }

            else if (opcao == 8)
            {
                Console.WriteLine("Programa encerrado.");
            }

            else
            {
                Console.WriteLine("Opção inválida!");
            }

        } while (opcao != 8);
    }
}