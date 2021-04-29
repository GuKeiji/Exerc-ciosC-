using System;

namespace Exercícioterceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double salarioNovo;
            double acrescimo;


            Console.WriteLine("\nInsira seu salário");
            salario = double.Parse(Console.ReadLine());
            acrescimo = salario * 30/100;
            salarioNovo = salario + acrescimo;
            
            if(salario < 500)
            {
            Console.WriteLine("\nVocê terá um aumento de 30%\nSeu novo salário será: " + salarioNovo);
            }
            else {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSeu salário permanecerá o mesmo");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
