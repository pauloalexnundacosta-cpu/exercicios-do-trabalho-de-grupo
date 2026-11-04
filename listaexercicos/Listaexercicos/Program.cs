
using System;
using System.Collections.Generic;

namespace Listaexercicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            List<string> listacompras = new List<string>();

            Console.WriteLine("============ Exercício 1 - LISTAS (Funcionamento) ============\n");
            Console.WriteLine("Digite 5 itens para a lista de compras.\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite aqui o que quer adicionar à lista: ");
                string item = Console.ReadLine();

                listacompras.Insert(0, item); //Posição zero
            }


            Console.Clear();

            Console.WriteLine("=== Lista de Compras ===");

            for (int i = 1; i < listacompras.Count; i++)
            {
                Console.WriteLine($"item {i} - {listacompras[i]}");
            }

            // bonus completo para modificar os itens
            /* do
            {
                



                Console.WriteLine("\nQuer modificar algum item da lista? (s/n)");
                string resposta = Console.ReadLine().ToLower();

                if (resposta == "s")
                {
                    Console.Write("Digite o índice do item que deseja modificar: ");

                    if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < listacompras.Count)
                    {
                        Console.Write("Digite o novo item: ");
                        string novoItem = Console.ReadLine();

                        listacompras[indice] = novoItem;

                        Console.WriteLine("\nItem modificado com sucesso!");
                        Console.WriteLine("Pressione Enter para continuar.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido!");
                        Console.WriteLine("Pressione Enter para continuar.");
                        Console.ReadLine();
                    }
                }
                else if (resposta == "n")
                {
                    continuar = false;

                    Console.WriteLine("\n=== Lista Final ===");

                    foreach (string produto in listacompras)
                    {
                        Console.WriteLine(produto);
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Digite 's' ou 'n'.");
                    Console.ReadLine();
                }

            } while (continuar);*/
        }
    }
}
