﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title ="Comparison";
        int nil = 0, num = 0, max = 1;
        char cap = 'A', low = 'a';
        Console.Write("Equality:");
        Console.Write("\t (0==0) : " + (nil == num));
        Console.Write("\n\t\t(A==a) : " + (cap == low));
        Console.Write("\n\nInequality:");
        Console.Write("\t (0 != 1): " + (nil != max));
        Console.Write("\n\nGreater: ");
        Console.Write("\t (0 > 1) : " + (nil > max));
        Console.Write("\nLess: ");
        Console.Write("\t\t (0 < 1) : " + (nil < max));
        Console.Write("\n\nGreater/Equal");
        Console.Write("\t (0 >= 0)" + (nil >= num));
        Console.Write("\nLess or equal");
        Console.Write("\t (1 <= 0)" + (max <= nil));
        Console.ReadKey();

    }
}