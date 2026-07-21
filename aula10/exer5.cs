/*• Crie uma classe abstrata Livro, que possui título e autor. Crie uma classe
LivroInfantil, que possui uma idade minima para ser lida, e uma classe
LivroAcademico, que possui um código Orcid
• Crie uma classe Biblioteca, que possui uma lista de Livro.
• Crie um método para procurar apenas por LivroInfantil a partir de sua idade mínima
• Crie um método para procurar apenas por LivroAcademico a partir de seu código
Orcid
• Os métodos de busca devem ter o mesmo nome, mudando seus parâmetros*/
using System;
using System.Collections.Generic;


// =======================================
// Classe abstrata Livro
// Classe pai
// =======================================

// Como é abstrata, não podemos criar:
// Livro livro = new Livro(); ❌
//
// Ela serve como modelo para os livros.

abstract class Livro
{

    // Atributos protegidos
    // As classes filhas podem acessar

    protected string titulo;
    protected string autor;



    // Construtor da classe Livro

    public Livro(string titulo, string autor)
    {
        this.titulo = titulo;
        this.autor = autor;
    }



    // Método para mostrar informações

    public virtual void MostrarInformacoes()
    {
        Console.WriteLine(
            $"Título: {titulo} | Autor: {autor}"
        );
    }

}



// =======================================
// Classe LivroInfantil
// Herda de Livro
// =======================================

class LivroInfantil : Livro
{

    // Idade mínima para leitura

    private int idadeMinima;



    // Construtor

    public LivroInfantil(
        string titulo,
        string autor,
        int idadeMinima
    )
        : base(titulo, autor)
    {
        this.idadeMinima = idadeMinima;
    }



    // Getter para acessar a idade mínima

    public int GetIdadeMinima()
    {
        return idadeMinima;
    }



    // Sobrescreve a exibição

    public override void MostrarInformacoes()
    {
        Console.WriteLine(
            $"Livro Infantil - Título: {titulo} | Autor: {autor} | Idade mínima: {idadeMinima} anos"
        );
    }

}



// =======================================
// Classe LivroAcademico
// Herda de Livro
// =======================================

class LivroAcademico : Livro
{

    // Código ORCID do autor

    private string codigoOrcid;



    // Construtor

    public LivroAcademico(
        string titulo,
        string autor,
        string codigoOrcid
    )
        : base(titulo, autor)
    {
        this.codigoOrcid = codigoOrcid;
    }



    // Getter para acessar o ORCID

    public string GetCodigoOrcid()
    {
        return codigoOrcid;
    }



    // Sobrescreve a exibição

    public override void MostrarInformacoes()
    {
        Console.WriteLine(
            $"Livro Acadêmico - Título: {titulo} | Autor: {autor} | ORCID: {codigoOrcid}"
        );
    }

}





// =======================================
// Classe Biblioteca
// Possui uma lista de Livros
// =======================================

class Biblioteca
{

    // Lista que armazena qualquer tipo de Livro

    private List<Livro> livros;



    // Construtor

    public Biblioteca()
    {
        livros = new List<Livro>();
    }



    // Adiciona um livro na biblioteca

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }




    // =======================================
    // Busca Livro Infantil
    // =======================================

    // Mesmo nome do outro método,
    // porém recebe um inteiro.
    //
    // Esse método procura pela idade mínima.

    public void BuscarLivro(int idadeMinima)
    {

        Console.WriteLine(
            "\nLivros infantis encontrados:"
        );


        foreach(Livro livro in livros)
        {

            // Verifica se o livro é infantil

            if(livro is LivroInfantil infantil)
            {


                // Compara a idade mínima

                if(infantil.GetIdadeMinima() == idadeMinima)
                {
                    infantil.MostrarInformacoes();
                }

            }

        }

    }





    // =======================================
    // Busca Livro Acadêmico
    // =======================================

    // Mesmo nome do método anterior,
    // porém recebe uma string.
    //
    // Procura pelo código ORCID.

    public void BuscarLivro(string codigoOrcid)
    {

        Console.WriteLine(
            "\nLivros acadêmicos encontrados:"
        );


        foreach(Livro livro in livros)
        {


            // Verifica se o livro é acadêmico

            if(livro is LivroAcademico academico)
            {


                // Compara o código ORCID

                if(academico.GetCodigoOrcid() == codigoOrcid)
                {
                    academico.MostrarInformacoes();
                }

            }

        }

    }


}





// =======================================
// Classe Program
// =======================================

class Program
{

    static void Main()
    {


        // Criando uma biblioteca

        Biblioteca biblioteca = new Biblioteca();



        // Criando livros infantis

        LivroInfantil infantil1 = new LivroInfantil(
            "O Pequeno Príncipe",
            "Antoine de Saint-Exupéry",
            8
        );


        LivroInfantil infantil2 = new LivroInfantil(
            "Alice no País das Maravilhas",
            "Lewis Carroll",
            10
        );




        // Criando livros acadêmicos

        LivroAcademico academico1 = new LivroAcademico(
            "Introdução à Inteligência Artificial",
            "Russell",
            "0000-0001"
        );


        LivroAcademico academico2 = new LivroAcademico(
            "Machine Learning",
            "Tom Mitchell",
            "0000-0002"
        );




        // Adicionando livros na biblioteca

        biblioteca.AdicionarLivro(infantil1);

        biblioteca.AdicionarLivro(infantil2);

        biblioteca.AdicionarLivro(academico1);

        biblioteca.AdicionarLivro(academico2);




        // =======================================
        // Chamando os métodos de busca
        // =======================================


        // Busca Livro Infantil
        // Chama:
        // BuscarLivro(int idadeMinima)

        biblioteca.BuscarLivro(8);




        // Busca Livro Acadêmico
        // Chama:
        // BuscarLivro(string codigoOrcid)

        biblioteca.BuscarLivro("0000-0001");


    }

}