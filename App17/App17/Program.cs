using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи число n: ");
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Факторіал = " + factorial);
        }
    }
}
