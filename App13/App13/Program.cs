using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи число: ");
            int n = int.Parse(Console.ReadLine());

            bool result = (n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0);

            Console.WriteLine(result);
        }
    }
}
