using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;

            string[] entrada = Console.ReadLine().Split(' ');

            double A = double.Parse(entrada[0]);
            double B = double.Parse(entrada[1]);
            double C = double.Parse(entrada[2]);

            double triangulo = (A * C) / 2;
            double circulo = PI * (Math.Pow(C, 2));
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}
