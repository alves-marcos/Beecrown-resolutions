using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosBeecrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());

            double media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {media:F5}");
        }
    }
}
