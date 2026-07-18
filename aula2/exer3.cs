//Faça um programa que recebe nomes de diferentes animais
//Cada vez que o usuário digitar o nome de um animal, o programa deve
//checar se o nome já foi digitado anteriormente. Se foi, então deve ser exibido
//uma mensagem alertando que o nome já foi digitado
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> animais = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o nome de um animal: ");
            string nome = Console.ReadLine();

            bool encontrado = false;

            for (int j = 0; j < animais.Count; j++)
            {
                if (animais[j] == nome)
                {
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("Esse animal já foi digitado.");
            }
            else
            {
                animais.Add(nome);
            }
        }
    }
}