using System;

 
namespace BRF1
{
    class Program
    {
       
        static long Fatorial(int numero)
        {
         
            if (numero <= 1)
                return 1;
            else return numero * Fatorial(numero - 1);
        }

       
        static void Main(string[] args)
        {
          
            for (int i = 0; i <= 200; i++)
            {
                
                Console.WriteLine("{0} ! = {1}", i, Fatorial(i));
            }
           
            Console.ReadLine();
        }
    }
}