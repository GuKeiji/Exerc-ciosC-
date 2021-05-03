using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool check = true;
            string texto = "";
            string nome = "";
            string senha = "";
            while (check == true)
            {
                Console.WriteLine("\nInsira seu nome" + texto);
                nome = Console.ReadLine();
                // Console.WriteLine(nome);

                Console.WriteLine("\nInsira sua senha" + texto);
                senha = Console.ReadLine();
                // Console.WriteLine(senha);

                if (nome == senha)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cadastro inválido: Nome igual a senha");
                    Console.ForegroundColor = ConsoleColor.White;
                    texto = " novamente";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cadastro Efetuado");
                    Console.ForegroundColor = ConsoleColor.White;
                    check = false;
                    // texto = "";
                }
            }
        }
    }
}
