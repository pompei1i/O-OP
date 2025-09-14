using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main()
        {
            string[] parts = Console.ReadLine().Split(' ');
            int[] arr = new int[parts.Length];
            for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(parts[i]);

            int d = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == d) count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
