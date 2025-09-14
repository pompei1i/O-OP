using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи перше число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введи друге число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введи третє число: ");
            int c = int.Parse(Console.ReadLine());

            double average = (a + b + c) / 3.0;

            Console.WriteLine("Середнє = " + average);
        }
    }
}
