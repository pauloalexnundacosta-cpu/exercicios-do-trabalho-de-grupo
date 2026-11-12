using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primieroexemploo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string> { "Maçã", "Banana", "Uva" };

            // Consulta direta por índice (começa em 0)
            Console.WriteLine(frutas[1]);      // Banana

            // Posição que não existe (a lista só vai até ao índice 2)
            Console.WriteLine(frutas[5]);//vai dar erro 



            Console.WriteLine("Erro: posição fora do alcance da lista!");


        }
    }
}
