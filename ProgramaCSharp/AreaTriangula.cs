using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCSharp
{
    internal class AreaTriangula
    {
        static void Main(string[] args)
        {
            double area = 0;
            double altura = 0;
            double baseTriangulo = 0;

            Console.WriteLine("Área de um triangulo");
            Console.WriteLine("Informe a base do triangulo: ");
            String entrada = Console.ReadLine();
            baseTriangulo = Convert.ToDouble(entrada);

            Console.WriteLine("Informe a altura do triangulo: ");
            entrada = Console.ReadLine();
            altura = Convert.ToDouble(altura);

            area = (altura * baseTriangulo) / 2;

            Console.WriteLine("A area do triangulo é " + area);

            Console.ReadKey();

        }


    }
}
