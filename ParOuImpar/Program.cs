using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Verificando se números são pares ou impares");
            Console.Write("Informe o número para verificação: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2  == 0)
            {
                Console.WriteLine("O número " + num + " é par");
            }
            else
            {
                Console.WriteLine("O número " + num + " é impar");
            }
            Console.ReadKey();

        }
    }
}
