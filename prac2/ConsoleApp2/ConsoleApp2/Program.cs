using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            string[] parts = Console.ReadLine().Split(' ');
            int n = parts.Length;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = int.Parse(parts[i]);

            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[n];

            for (int r = 0; r < k; r++)
            {
                int last = arr[n - 1];
                for (int i = n - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = last;

                for (int i = 0; i < n; i++) sum[i] += arr[i];
            }

            for (int i = 0; i < n; i++) Console.Write(sum[i] + " ");
        }
    }
}
