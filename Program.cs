using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;
            char sinal;

            Console.WriteLine("Insira o primeiro número:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um sinal(+,-,/,*)");
            sinal = char.Parse(Console.ReadLine());

            switch (sinal)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine(resultado);
                    break;

                case '/':
                    resultado = num1 / num2;
                    Console.WriteLine(resultado);
                    break;

                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine(resultado);
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
