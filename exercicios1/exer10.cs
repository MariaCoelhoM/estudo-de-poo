/*Uma empresa que vende ingressos de shows te contratou para fazer um sistema para eles.
Um show possui uma quantidade específica de ingressos. Um ingresso possui um valor,
que varia de acordo com o seu tipo:
- Ingresso Normal: R$ 40,00
- Ingresso VIP: R$ 80,00
Os ingressos VIPs ainda podem ser divididos em novas categorias, que variam os
benefícios:
- Ingresso VIP Camarote: possui o valor de R$ 80,00, e oferece R$ 20 para gastos no
bar
- Ingresso VIP Experience: possui o valor de R$ 100, e oferece R$ 50 para gastos no
bar
Uma pessoa deve poder comprar quantos ingressos ela quiser, dos diferentes tipos, desde
que eles estejam disponíveis. Ao finalizar a compra, deve ser decretada a disponibilidade de
cada ingresso.*/
using System;
class Ingresso
{
    // Atributos
    public string Nome;
    public int Quantidades;
    public string Ingressos;
    public double Total;
    public int QuantidadeIngresso = 10;
    public double IngressoNormal = 40.00;
    public double IngressoVip = 80.00;
    public double IngressoVipCamarote = 80.00;
    public double IngressoVipExperience = 100.00;

    // Método
    public void Comprar()
    {
        if(Ingressos == "Ingresso Normal" && Quantidades <= QuantidadeIngresso)
        {
            Console.WriteLine("Sua compra foi bem sucedida!");
            QuantidadeIngresso -= Quantidades;
            Total += Quantidades * IngressoNormal;
        }
        else if(Ingressos == "Ingresso VIP" && Quantidades <= QuantidadeIngresso)
        {
            Console.WriteLine("Sua compra foi bem sucedida!");
            QuantidadeIngresso -= Quantidades;
            Total += Quantidades * IngressoVip;
        }
        else if(Ingressos == "Ingresso VIP Camarote" && Quantidades <= QuantidadeIngresso)
        {
            Console.WriteLine("Sua compra foi bem sucedida!");
            Console.WriteLine("Você recebeu R$ 20 para consumir no bar!");
            QuantidadeIngresso -= Quantidades;
            Total += Quantidades * IngressoVipCamarote;
        }
         else if(Ingressos == "Ingresso VIP Experience" && Quantidades <= QuantidadeIngresso)
        {
            Console.WriteLine("Sua compra foi bem sucedida!");
            Console.WriteLine("Você recebeu R$ 50 para consumir no bar!");
            QuantidadeIngresso -= Quantidades;
            Total += Quantidades * IngressoVipExperience;
        }
        else
        {
            Console.WriteLine("Ingressos indiponiveis!");
        }
    }
}

class Program : Ingresso
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Pessoa
        Ingresso ingresso = new Ingresso();

        Console.WriteLine("Digite seu nome: ");
        ingresso.Nome = Console.ReadLine();

        Console.WriteLine("Digite aqui qual ingresso você deseja: ");
        ingresso.Ingressos = Console.ReadLine();

        Console.WriteLine("Digite aqui quantos ingressos quer comprar: ");
        ingresso.Quantidades = int.Parse(Console.ReadLine());

        ingresso.Comprar();
        Console.WriteLine();
        Console.WriteLine("----------Relatorio:------------");
        Console.WriteLine($"Nome: {ingresso.Nome}");
        Console.WriteLine($"Tipo do ingresso: {ingresso.Ingressos}");
        Console.WriteLine($"Quantidade: {ingresso.Quantidades}");
        Console.WriteLine($"Gasto: {ingresso.Total}");
    }
}
