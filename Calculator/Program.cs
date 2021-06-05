using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplicacao();
        }

        static void Soma() {
            Console.Clear();
            
            Console.Write("Primeiro valor: ");
            double v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = float.Parse(Console.ReadLine());

            double soma = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {soma}");
            
            Console.ReadKey();
        }

        static void Subtracao() {
            Console.Clear();
            
            Console.Write("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 - v2;
            Console.WriteLine($"O resto da subtração é {resultado}");
        
            Console.ReadKey();
        }

        static void Divisao() {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
        
            double resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.ReadKey();
        }

        static void Multiplicacao() {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Console.ReadKey();
        }
    }
}
