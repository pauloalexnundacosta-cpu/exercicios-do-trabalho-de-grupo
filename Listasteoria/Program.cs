using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //exempploo

        List<string> frutas = new List<string> { "Maçã", "Banana", "Kaiser" };
        //     ↑                    ↑
        //  Tipo do objeto      Construtor (cria o objeto)


        List<string> novasFrutas = new List<string> { "Uva", "Pera" };

        frutas.AddRange(novasFrutas); //Metodo AddRange adiciona uma lista de elementos no final da lista

        frutas.Insert(0, "pão"); // insere "Pão" na posição 0

        frutas.Remove("Banana"); // remove o item "Banana"

        frutas.RemoveAt(2); // remove o item na posição 2

        frutas.Add("Laranja"); //Metodo Add adiciona um elemento no final da lista





        Console.WriteLine("=== Frutas ===");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }




        for (int i = 0; i < frutas.Count; i++)
        {
            Console.WriteLine($"Índice {i}: {frutas[i]}"); // For permite modificar




        }

        Console.WriteLine("\n=== Frutas (usando string.Join) ===");
        Console.WriteLine(string.Join(" \n", frutas));
    }
}