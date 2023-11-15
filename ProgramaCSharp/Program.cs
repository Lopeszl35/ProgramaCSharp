using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escrevendo a tabuada");
            Console.WriteLine("Digite o número que deseja a tabuada: ");
            string entrada = Console.ReadLine();

            if(int.TryParse(entrada, out int num))
            {
                for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num + " x " + i + " = " + (num * i));
                }
            }
            else
            {
                Console.WriteLine("Número informado inválido");
            }

            Console.ReadKey();
        }
    }
}
