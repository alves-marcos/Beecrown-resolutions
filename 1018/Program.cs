using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdNotas100 = 0, qtdNotas50 = 0, qtdNotas20 = 0, qtdNotas10 = 0, qtdNotas5 = 0, qtdNotas2 = 0, qtdNotas1 = 0;



            int value = int.Parse(Console.ReadLine());

            #region Condicao

            if (value >= 100)
            {
                qtdNotas100 = value / 100;
                value = value % 100;
            }
            else
            {
                qtdNotas100 = 0;
            }

            if (value >= 50)
            {
                qtdNotas50 = value / 50;
                value = value % 50;
            }
            else
            {
                qtdNotas50 = 0;
            }

            if (value >= 20)
            {
                qtdNotas20 = value / 20;
                value = value % 20;
            }
            else
            {
                qtdNotas20 = 0;
            }

            if (value >= 10)
            {
                qtdNotas10 = value / 10;
                value = value % 10;
            }
            else
            {
                qtdNotas10 = 0;
            }

            if (value >= 5)
            {
                qtdNotas5 = value / 5;
                value = value % 5;
            }
            else
            {
                qtdNotas5 = 0;
            }

            if (value >= 2)
            {
                qtdNotas2 = value / 2;
                value = value % 2;
            }
            else
            {
                qtdNotas2 = 0;
            }

            qtdNotas1 = value;


            #endregion

            Console.WriteLine($"{qtdNotas100} nota(s) de R$ 100,00");
            Console.WriteLine($"{qtdNotas50} nota(s) de R$ 50,00");
            Console.WriteLine($"{qtdNotas20} nota(s) de R$ 20,00");
            Console.WriteLine($"{qtdNotas10} nota(s) de R$ 10,00");
            Console.WriteLine($"{qtdNotas5} nota(s) de R$ 5,00");
            Console.WriteLine($"{qtdNotas2} nota(s) de R$ 2,00");
            Console.WriteLine($"{qtdNotas1} nota(s) de R$ 1,00");
        }
    }
}
