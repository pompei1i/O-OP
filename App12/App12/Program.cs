using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи число: ");
            int n = int.Parse(Console.ReadLine());

            bool result = (n > 20) && (n % 2 != 0);

            Console.WriteLine(result);
        }
    }
}
