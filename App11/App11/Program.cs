using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи число: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Яку цифру з права хочеш? ");
            int n = int.Parse(Console.ReadLine());

            int result;

            if (n > 0)
            {
                result = (number / (int)Math.Pow(10, n - 1)) % 10;

                if (result == 0 && number < Math.Pow(10, n - 1))
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("Цифра = " + result);
                }
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
