using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = (4 / 3.0) * PI * Math.Pow(raio, 3);

            Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
