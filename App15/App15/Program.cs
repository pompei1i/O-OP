using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введи b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введи c: ");
            double c = double.Parse(Console.ReadLine());

            int negativeCount = 0;

            if (a < 0) negativeCount++;
            if (b < 0) negativeCount++;
            if (c < 0) negativeCount++;

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Добуток = 0");
            }
            else if (negativeCount % 2 == 0)
            {
                Console.WriteLine("Знак добутку = Позитивний");
            }
            else
            {
                Console.WriteLine("Знак добутку = Негативний");
            }
        }
    }
}
