using System;

namespace Desafio_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            int F = 1;
            int n = 1;
            int resultado = 0;
            // int z;

            Console.WriteLine("\n-----------Sequência de Fibonatchê-----------\n");
            Console.WriteLine(resultado);
            Console.WriteLine(F);
            Console.WriteLine(n);

            while(resultado < 500)
            {
                // z = F * (n + 2);
                // resultado = z + F * (n + 1) + F *(n);
                resultado = F + n;
                Console.WriteLine(resultado);
                n = F;

                F = resultado;
            }
            Console.WriteLine("\n-----------Fim da Sequência de Fibonatchê-----------\n");
            
        }
    }
}
