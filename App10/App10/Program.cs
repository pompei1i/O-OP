using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи число: ");
            int n = int.Parse(Console.ReadLine());

            int lastDigit = n % 10;

            Console.WriteLine("Остання цифра = " + lastDigit);
        }
    }
}
