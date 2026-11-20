using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());


            int hour = Convert.ToInt32(Console.ReadLine());
            double valueH = Convert.ToDouble(Console.ReadLine());

            double salary = hour * valueH;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine($"SALARY = U$ {salary:F2}");

        }
    }
}
