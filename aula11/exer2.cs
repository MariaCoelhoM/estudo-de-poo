/*• Crie a classe Contato, que possui um nome e um telefone
• Crie uma classe ListaContato, que possui uma lista de contatos
• Crie uma classe DicionarioContato, que possui um dicionário de contatos
• Crie uma interface chamada IAdicionavel, que possui um método Adicionar, que recebe uma string nome e
uma string telefone
• Crie uma interface chamada IBuscavel, que possui um método Buscar que recebe uma string nome e retorna
um Contato
• Implemente IAdicionavel e IBuscavel em ListaContato e DicionarioContato, de forma que seja implementada a
busca e a adição em cada uma das estruturas
• Crie uma instancia de ListaContato e uma de DicionarioContato. Adicione contatos para cada uma. Em seguida,
adicione ambas em uma lista de IBuscavel. Em seguida, percorra a lista, chamando o método Buscar*/
using System;
using System.Collections.Generic;



// =======================================
// Classe Contato
// Representa um contato da agenda
// =======================================

class Contato
{

    // Atributos

    public string Nome { get; set; }

    public string Telefone { get; set; }




    // Construtor

    public Contato(string nome, string telefone)
    {
        Nome = nome;

        Telefone = telefone;
    }





    // Método para mostrar contato

    public void MostrarContato()
    {
        Console.WriteLine(
            $"Nome: {Nome} | Telefone: {Telefone}"
        );
    }

}





// =======================================
// Interface IAdicionavel
// Define que a classe deve possuir
// um método Adicionar
// =======================================

interface IAdicionavel
{

    void Adicionar(
        string nome,
        string telefone
    );

}





// =======================================
// Interface IBuscavel
// Define que a classe deve possuir
// um método Buscar
// =======================================

interface IBuscavel
{

    Contato Buscar(string nome);

}





// =======================================
// Classe ListaContato
// Utiliza uma List<Contato>
// =======================================

class ListaContato : IAdicionavel, IBuscavel
{

    // Lista que armazenará os contatos

    private List<Contato> contatos;



    // Construtor

    public ListaContato()
    {
        contatos = new List<Contato>();
    }





    // =======================================
    // Implementação do método Adicionar
    // =======================================

    public void Adicionar(
        string nome,
        string telefone
    )
    {

        // Cria um novo contato

        Contato contato = new Contato(
            nome,
            telefone
        );



        // Adiciona na lista

        contatos.Add(contato);


    }





    // =======================================
    // Implementação do método Buscar
    // =======================================

    public Contato Buscar(string nome)
    {


        // Percorre todos os contatos

        foreach(Contato contato in contatos)
        {

            // Verifica se encontrou o nome

            if(contato.Nome == nome)
            {
                return contato;
            }

        }



        // Caso não encontre

        return null;

    }

}





// =======================================
// Classe DicionarioContato
// Utiliza Dictionary
// =======================================

class DicionarioContato : IAdicionavel, IBuscavel
{

    // Dicionário:
    //
    // chave -> nome
    // valor -> contato

    private Dictionary<string, Contato> contatos;




    // Construtor

    public DicionarioContato()
    {

        contatos = new Dictionary<string, Contato>();

    }





    // =======================================
    // Implementação do método Adicionar
    // =======================================

    public void Adicionar(
        string nome,
        string telefone
    )
    {

        // Cria contato

        Contato contato = new Contato(
            nome,
            telefone
        );



        // Adiciona no dicionário
        //
        // O nome será a chave

        contatos.Add(
            nome,
            contato
        );

    }





    // =======================================
    // Implementação do método Buscar
    // =======================================

    public Contato Buscar(string nome)
    {


        // Verifica se existe
        // uma chave com esse nome

        if(contatos.ContainsKey(nome))
        {

            return contatos[nome];

        }



        // Caso não encontre

        return null;

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
        // Criando uma ListaContato
        // =======================================

        ListaContato lista = new ListaContato();



        lista.Adicionar(
            "Maria",
            "99999-1111"
        );


        lista.Adicionar(
            "Ana",
            "99999-2222"
        );





        // =======================================
        // Criando um DicionarioContato
        // =======================================

        DicionarioContato dicionario =
            new DicionarioContato();



        dicionario.Adicionar(
            "Carlos",
            "99999-3333"
        );


        dicionario.Adicionar(
            "João",
            "99999-4444"
        );





        // =======================================
        // Criando lista de IBuscavel
        // =======================================

        // Podemos colocar objetos diferentes
        // porque ambos implementam IBuscavel

        List<IBuscavel> buscas =
            new List<IBuscavel>();



        buscas.Add(lista);

        buscas.Add(dicionario);





        Console.WriteLine(
            "===== BUSCAS =====\n"
        );




        // Percorre todas as estruturas

        foreach(IBuscavel busca in buscas)
        {


            // Procura um contato

            Contato contato =
                busca.Buscar("Maria");



            // Verifica resultado

            if(contato != null)
            {

                contato.MostrarContato();

            }
            else
            {

                Console.WriteLine(
                    "Contato não encontrado."
                );

            }

        }



    }

}