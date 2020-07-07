using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRF1
{
 
    class SomaFatorial
    {
        static long SomaDigitos(int numero)
        {
            int somaFact = 0;

            while (numero != 0)
            {
                somaFact += numero % 10;
                numero = numero / 10;
            }

            return somaFact;
        }

        }
        static void Main(string[] args)
        {
            int i, numero, fact;
            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());
            fact = numero;
            for (i = numero - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            
            Console.WriteLine("\n o fatorial do numero é : "+fact);
            Console.ReadLine();
            int somaFact = 0;
            Console.WriteLine("\n a soma do fatorial é:" + somaFact);

        }
    }
}
