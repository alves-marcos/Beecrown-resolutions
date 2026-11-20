using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada1 = Console.ReadLine().Split(' ');
            string[] entrada2 = Console.ReadLine().Split(' ');

            double valor0 = double.Parse(entrada1[1]);
            double valor1 = double.Parse(entrada1[2]);

            double valor2 = double.Parse(entrada2[1]);
            double valor3 = double.Parse(entrada2[2]);

            double total = ((valor0 * valor1) + (valor2 * valor3));

            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
        }
    }
}
