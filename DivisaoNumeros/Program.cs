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

            Console.WriteLine("Programa que efetua a divisão de dois números");
            for (int i = 1; i <= 2; i++)
            {
                Console.Write("Informe o " + i + "º número: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o " + i + "° número: ");
                n2 = Convert.ToDouble(Console.ReadLine());
            }
        }

    }
}
