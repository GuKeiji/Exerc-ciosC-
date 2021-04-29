using System;

namespace Exercíciosegundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento;
            int anoAtual;
            int idade;
            double semanas;

            Console.WriteLine("\nInsira o ano em que nasceu");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o ano atual");
            anoAtual = int.Parse(Console.ReadLine());

            idade = anoAtual - anoNascimento;
            semanas = idade * 52.143;

            Console.WriteLine("\nSua idade é: " + idade);
            Console.WriteLine("\nSua idade em semanas é aproximadamente: " + semanas.ToString("0"));
        }
    }
}
