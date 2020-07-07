using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRF1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <= 2000; i++)
            {
                soma += i;
            }

            Console.WriteLine(soma);
        }
        
    }
}

