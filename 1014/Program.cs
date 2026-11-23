using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maior = num[0];

            foreach (int x in num)
            {
                maior = Math.Max(maior, x);
            }
            Console.WriteLine(maior);
        }
    }
}
