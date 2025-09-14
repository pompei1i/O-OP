using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] prime = new bool[n + 1];
            for (int i = 2; i <= n; i++) prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p])
                {
                    for (int j = p * p; j <= n; j += p) prime[j] = false;
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (prime[i]) Console.Write(i + " ");
            }
        }
    }
}
