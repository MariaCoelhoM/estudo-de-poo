using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> frutas = new List<string>();

        frutas.Add("Maçã");

        frutas.Add("Banana");

        frutas.Add("Uva");

        foreach(string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}