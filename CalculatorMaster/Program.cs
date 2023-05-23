using System.Diagnostics;
using System;

namespace CalculatorMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Sum(){
            Console.WriteLine("Informe o primeiro valor:");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float result = numberOne + numberTwo;
            Console.WriteLine($"A soma total é = {result}");
            Console.ReadKey();
        }

        static void Subtract(){
            Console.WriteLine("Informe o primeiro valor:");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float result = numberOne - numberTwo;
            Console.WriteLine($"A subtração total é = {result}");
            Console.ReadKey();
        }

        static void Division(){
            Console.WriteLine("Informe o primeiro valor:");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float result = numberOne / numberTwo;
            Console.WriteLine($"A divisão total é = {result}");
            Console.ReadKey();
        }

        static void Multiple(){
            Console.WriteLine("Informe o primeiro valor:");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float result = numberOne * numberTwo;
            Console.WriteLine($"A multplicação total é = {result}");
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.WriteLine("Informe a opção no menu");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("0 - Sair da Aplicação");
            int opcao = int.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Division();
                    break;
                case 4:
                    Multiple();
                    break;
                default:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
