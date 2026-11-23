using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int averageDistance = int.Parse(Console.ReadLine());

            double liters = (hour * averageDistance) / 12.0;

            Console.WriteLine($"{liters:F3}");
        }
    }
}
