using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
         


                int distancia = int.Parse(Console.ReadLine());
                double km = double.Parse(Console.ReadLine());

                double consumo = distancia / km;

                Console.WriteLine($"{consumo:F3} km/l");

            }

        }
    
    
}
