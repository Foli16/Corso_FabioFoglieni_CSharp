using System;

class Program
{
    static void Main()
    {
        int a = 2, b = 9;
        Console.WriteLine($"Risultato: {Somma(a, b)}");
    }

    private static int Somma(int a, int b)
    {
        return a + b;
    }
}