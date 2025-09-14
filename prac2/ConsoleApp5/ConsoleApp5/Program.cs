using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            string a = Console.ReadLine().Replace(" ", "");
            string b = Console.ReadLine().Replace(" ", "");

            if (String.Compare(a, b) <= 0)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }
    }
}
