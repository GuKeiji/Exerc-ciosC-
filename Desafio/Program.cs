using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int vezes = 0;
            bool check = false;
            string resposta = "";
            while (check == false)
            {
                Console.WriteLine("\nInsira sua idade");
                idade = int.Parse(Console.ReadLine());
                // while (idade < 5)
                // {

                //     if (vezes >= 1)
                //     {
                //         Console.ForegroundColor = ConsoleColor.Yellow;
                //         Console.WriteLine("Insira sua idade novamente");
                //         Console.ForegroundColor = ConsoleColor.White;
                //     }
                    // else
                    // {
                    //     Console.WriteLine("\nInsira sua idade");
                    // }

                    // idade = int.Parse(Console.ReadLine());

                //     if (idade < 5)
                //     {
                //         Console.ForegroundColor = ConsoleColor.Red;
                //         Console.WriteLine("\nIdade inválida\n");
                //         Console.ForegroundColor = ConsoleColor.White;
                //         vezes++;
                //     }

                // }

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("\nVocê está na categoria Infantil A");
                }
                else
                {
                    if (idade >= 8 && idade <= 10)
                    {
                        Console.WriteLine("\nVocê está na categoria Infantil B");
                    }
                    else
                    {
                        if (idade >= 11 && idade <= 13)
                        {
                            Console.WriteLine("\nVocê está na categoria Juvenil A");
                        }
                        else
                        {
                            if (idade >= 14 && idade <= 17)
                            {
                                Console.WriteLine("\nVocê está na categoria Juvenil B");
                            }
                            else
                            {
                                Console.WriteLine("\nSinto muito, não temos categorias para sua idade");
                            }
                        }
                    }
                }
                Console.WriteLine("Deseja inserir outra idade? (s/n)");
                resposta = Console.ReadLine().ToLower();
                if (resposta == "n")
                {
                    check = true;
                }

            }


        }
    }
}
