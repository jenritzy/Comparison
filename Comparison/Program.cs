internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title ="Comparison";
        int nil = 0, num = 0, max = 1;
        char cap = 'A', low = 'a';
        Console.Write("Equality:");
        Console.Write("\t (0==0) : " + (nil + num));
        Console.WriteLine("\n\t\t(A==a) : " + (cap == low));
    }
}