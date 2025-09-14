using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            string[] parts = Console.ReadLine().Split(' ');
            int[] arr = new int[parts.Length];
            for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(parts[i]);

            int bestLen = 1, bestStart = 0;
            int curLen = 1, curStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    curLen++;
                    if (curLen > bestLen) { bestLen = curLen; bestStart = curStart; }
                }
                else
                {
                    curLen = 1;
                    curStart = i;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; i++) Console.Write(arr[i] + " ");
        }
    }
}
