using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Write(string.Join(",", Fibonacci(10)));
        Console.ReadKey();
    }

    public static IEnumerable<string> Fibonacci(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
            yield return a.ToString();
        }
    }
}
