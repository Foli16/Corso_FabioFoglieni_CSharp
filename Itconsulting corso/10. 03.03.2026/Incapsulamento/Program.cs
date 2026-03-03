using System;

class Program
{
    static void Main()
    {
        ContoBancario conto = new ContoBancario();

        conto.Saldo = 1000.5;
        Console.WriteLine(conto.Saldo);

        conto.Saldo = -500;
        Console.WriteLine(conto.Saldo);
    }
}