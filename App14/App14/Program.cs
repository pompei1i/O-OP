using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введи b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введи c: ");
            int c = int.Parse(Console.ReadLine());

            int max;

            if (a >= b && a >= c)
            {
                max = a;
            }
            else if (b >= a && b >= c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            Console.WriteLine("Найбільше число = " + max);
        }
    }
}
