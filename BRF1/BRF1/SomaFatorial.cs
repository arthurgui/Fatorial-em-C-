using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRF1
{
    class SomaFatorial
    {
          static void Main(string[] args)
        {
            int i, number, fact;
            Console.WriteLine("Digite um numero");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\n o fatorial do numero é : "+fact);
            Console.ReadLine();

        }
    }
}
