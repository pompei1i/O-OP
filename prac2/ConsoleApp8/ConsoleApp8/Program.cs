using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main()
        {
            string[] parts = Console.ReadLine().Split(' ');
            int[] arr = new int[parts.Length];
            for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(parts[i]);

            int bestNum = arr[0];
            int bestCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) count++;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestNum = arr[i];
                }
            }

            Console.WriteLine(bestNum);
            Console.WriteLine("Число " + bestNum + " зустрічається " + bestCount + " раз(и)");
        }
    }
}
