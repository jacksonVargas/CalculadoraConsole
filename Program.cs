using System;
using System.Reflection.Metadata;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Qual das operações você deseja: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 0 : 
                    Sair();
                break;

                case 1 : 
                    Soma();
                break;

                case 2 : 
                    Subtracao();
                break;

                case 3 : 
                    Divisao();
                break;

                case 4 : 
                    Multiplicacao();
                break;

                default:
                    Console.WriteLine("Ouve algum problema, desculpe");
                break;
            }
        }

        static void Soma() 
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;

            Console.Clear();
            Console.WriteLine($"A soma é: {result}");
        }

        static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 - num2;

            Console.Clear();
            Console.WriteLine($"A subtração é: {result}");
        }

        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 / num2;

            Console.Clear();
            Console.WriteLine($"A divisão é: {result}");
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 * num2;

            Console.Clear();
            Console.WriteLine($"A multiplicação é: {result}");
        }
        
        static void Sair() 
        {
            Console.Clear();
            Console.WriteLine("Bye :)");
            System.Environment.Exit(0);
        }
    }
}
