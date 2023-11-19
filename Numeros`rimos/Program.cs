using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int exit = 1;
            
            while (exit != 0)
            {
                Console.WriteLine("Número Primo");
                Console.Write("Informe um número: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int i = 1;
                while (i <= num)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                    i++;
                }
                if (count == 2)
                {
                    Console.WriteLine("O número " + num + " é primo");
                }
                else
                {
                    Console.WriteLine("O número " + num + " não é primo");
                }

                
                //Controle de repetição do programa
                Console.Write("Digite 0 para sair: ");
                exit = Convert.ToInt32(Console.ReadLine()); 
                Console.Clear();
            }

        }
    }
}
