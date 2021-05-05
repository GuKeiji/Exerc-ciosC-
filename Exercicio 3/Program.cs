using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;
            float salario;
            string estadoCivil;
            string texto = "";
            bool check = false;
            string letra;

            while (check == false)
            {
                Console.WriteLine("Insira seu nome" + texto);
                nome = Console.ReadLine();

                if (nome == "")
                {
                    Console.WriteLine("Nome inválido");
                    texto = " novamente";
                }
                else
                {
                    Console.WriteLine("Nome salvo");
                    check = true;
                    texto = "";
                }
            }

            while (check == true)
            {
                Console.WriteLine("Insira sua idade" + texto);
                idade = int.Parse(Console.ReadLine());

                if (idade > 150)
                {
                    Console.WriteLine("Idade inválida");
                    texto = " novamente";
                }
                else
                {
                    Console.WriteLine("Idade salva");
                    check = false;
                    texto = "";
                }
            }

            while (check == false)
            {
                Console.WriteLine("Insira seu salário" + texto);
                salario = float.Parse(Console.ReadLine());

                if (salario <= 0)
                {
                    Console.WriteLine("Salário inválido");
                    texto = " novamente";
                }
                else
                {
                    Console.WriteLine("Salário salvo");
                    check = true;
                    texto = "";
                }
            }
                while (check == true)
                {
                    Console.WriteLine("Insira seu Estado Civil" + texto);
                    estadoCivil = Console.ReadLine().ToLower();
                    letra = estadoCivil.Substring(0, 1);

                    if (letra == "s")
                    {
                        Console.WriteLine("Estado Civil salvo");
                        check = false;
                    }
                    else if (letra == "c")
                    {
                        Console.WriteLine("Estado Civil salvo");
                        check = false;
                    }
                    else if (letra == "v")
                    {
                        Console.WriteLine("Estado Civil salvo");
                        check = false;
                    }
                    else if (letra == "d")
                    {
                        Console.WriteLine("Estado Civil salvo");
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("Estado Civil inválido");
                        texto = " novamente";
                    }


















                    // switch (letra)
                    // {
                    //     case "s":
                    //         Console.WriteLine("Estado Civil salvo");
                    //         check = false;
                    //         break;

                    //     case "c":
                    //         Console.WriteLine("Estado Civil salvo");
                    //         check = false;
                    //         break;

                    //     case "v":
                    //         Console.WriteLine("Estado Civil salvo");
                    //         check = false;
                    //         break;

                    //     case "d":
                    //         Console.WriteLine("Estado Civil salvo");
                    //         check = false;
                    //         break;

                    //     default:
                    //         Console.WriteLine("Estado Civil inválido");
                    //         texto = " novamente";
                    //         break;
                    // }
                }
            
        }
    }
}