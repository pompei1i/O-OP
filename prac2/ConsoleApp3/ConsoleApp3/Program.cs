using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            string[] parts = Console.ReadLine().Split(' ');
            int n = parts.Length;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = int.Parse(parts[i]);

            int k = n / 4;
            int[] top = new int[2 * k];
            int[] bottom = new int[2 * k];

            for (int i = 0; i < k; i++) top[i] = arr[k - 1 - i];
            for (int i = 0; i < k; i++) top[k + i] = arr[n - 1 - i];

            for (int i = 0; i < 2 * k; i++) bottom[i] = arr[k + i];

            for (int i = 0; i < 2 * k; i++) Console.Write(top[i] + bottom[i] + " ");
        }
    }
}
