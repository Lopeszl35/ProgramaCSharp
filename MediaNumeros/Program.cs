using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quant = 0;
            int soma = 0;
            double media = 0;
            int num = 0;

            Console.WriteLine("Calculando a média de N números");
            Console.Write("Informe quantos números seram informados: ");
            quant = Convert.ToInt32(Console.ReadLine());

            for(int  i = 0; i < quant; i++)
            {
                Console.Write("Informe o " + (i+1) + "° número: ");
                num = Convert.ToInt32(Console.ReadLine());
                soma += num;
            }
            media = (double)soma / quant;

            Console.WriteLine("A média dos números é = " +  media);

        }
    }
}
