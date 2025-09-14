using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine().ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c >= 'a' && c <= 'z')
                {
                    int index = c - 'a';
                    Console.WriteLine(c + " -> " + index);
                }
            }
        }
    }
}
