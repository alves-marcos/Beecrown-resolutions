using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] p1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] p2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double x1 = p1[0];
            double y1 = p1[1];

            double x2 = p2[0];
            double y2 = p2[1];

            double distancia = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

            Console.WriteLine($"{distancia:F4}");
        }
    }
}
