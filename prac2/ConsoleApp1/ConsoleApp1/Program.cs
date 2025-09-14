using System;

class Program
{
    static void Main()
    {
        string[] a = Console.ReadLine().Split(' ');
        string[] b = Console.ReadLine().Split(' ');

        int n = Math.Min(a.Length, b.Length);

        int left = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == b[i]) left++;
            else break;
        }

        int right = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[a.Length - 1 - i] == b[b.Length - 1 - i]) right++;
            else break;
        }

        if (left >= right)
        {
            Console.WriteLine(left);
            for (int i = 0; i < left; i++) Console.Write(a[i] + " ");
        }
        else
        {
            Console.WriteLine(right);
            for (int i = a.Length - right; i < a.Length; i++) Console.Write(a[i] + " ");
        }
    }
}