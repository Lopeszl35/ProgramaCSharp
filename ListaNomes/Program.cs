using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando o array com tamaho 10
            string[] lista = new string[5];
            //string nome = "";

            Console.WriteLine("Lista de nomes: ");

            for(int i = 0; i < lista.Length; i++)
            {
                Console.Write("Informe o " + (i + 1) + "° nome: ");
                lista[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Nomes inseridos");
            Console.WriteLine();
            for(int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadKey();

            
        }
    }
}
