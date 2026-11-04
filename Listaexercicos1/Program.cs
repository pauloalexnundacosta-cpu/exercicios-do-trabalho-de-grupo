using System;
using System.Collections.Generic;

namespace Listaexercicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> notas = new List<int>();

            Console.WriteLine("============ Exercício 2 - NOTAS ============\n");

            // Adicionar as notas
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                int nota = Convert.ToInt32(Console.ReadLine());
                notas.Add(nota);
            }

            //Mostrar pela ordem 
            Console.WriteLine("\nNotas originais:");
            foreach (int n in notas)
            {
                Console.WriteLine(n);
            }

            //Ordenar (menor para o maior)
            notas.Sort();
            Console.WriteLine("\nNotas ordenadas:");
            foreach (int n in notas)
            {
                Console.WriteLine(n);
            }

            //a menor está no início e a maior no fim
            Console.WriteLine($"\nMenor nota: {notas[0]}");
            Console.WriteLine($"Maior nota: {notas[notas.Count]}");

            // 5. Média um bonus
            int soma = 0;
            foreach (int n in notas)
            {
                soma += n;
            }
            Console.WriteLine($"Média: {soma / notas.Count}");
        }
    }
}