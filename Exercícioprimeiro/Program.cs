using System;

namespace Exercícioprimeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int meses = 0;
            int dias = 0;
            int horas = 0;
            int minutos = 0;
            bool check = true;
            int vezes = 0;
            string texto = "";

            while (check == true)
            {
                if (vezes >= 1)
                {
                    texto = " novamente";
                }

                Console.WriteLine("Insira sua idade" + texto);
                idade = int.Parse(Console.ReadLine());

                if (idade < 150)
                {
                    meses = idade * 12;
                    dias = idade * 365;
                    horas = idade * 8760;
                    minutos = horas * 60;
                    Console.WriteLine("\nMeses: " + meses);
                    Console.WriteLine("Dias: " + dias);
                    Console.WriteLine("Horas: " + horas);
                    Console.WriteLine("Minutos: " + minutos);
                    check = false;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desculpe, mas você é um difunto!!!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    vezes++;
                }



            }
        }
    }
}
