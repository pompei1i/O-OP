using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введи b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введи h: ");
            double h = double.Parse(Console.ReadLine());

            double area = (a + b) * h / 2;

            Console.WriteLine("Площа = " + area);
        }
    }
}
