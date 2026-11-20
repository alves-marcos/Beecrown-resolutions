using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            double salary = Convert.ToDouble(Console.ReadLine());
            double sales = Convert.ToDouble(Console.ReadLine());

            double total = salary + (sales * 0.15);

            Console.WriteLine($"TOTAL = R$ {total:F2}");
        }
    }
}
