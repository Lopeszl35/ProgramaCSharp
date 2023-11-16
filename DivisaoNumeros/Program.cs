using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCSharp
{
    internal class DivisaoDeDoisNumeros
    {
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;
            double resto = 0;
            double quociente = 0;
            List<double> lista = new List<double>();

            Console.WriteLine("Programa que efetua a divisão de dois números");
            for (int i = 0; i <= 1; i++)
            {
                Console.Write("Informe o " + (i+1) + "º número: ");
                lista.Add(Convert.ToDouble(Console.ReadLine()));
            }

            quociente = lista[0] / lista[1];
            resto = lista[0] % lista[1];


            Console.WriteLine("O quociente da divisão é = " + quociente);
            Console.WriteLine("O resto da divisão é = " +  resto);
            Console.ReadKey();
        }

    }
}
