using System;

enum Prodotto
{
    Gelato,
    Olio,
    Mela
}
class Program
{
    static void Main()
    {
        Console.WriteLine($"Prodotto 1: {Prodotto.Mela}");

        Prodotto p = Prodotto.Gelato;

        switch(p)
        {
            case Prodotto.Gelato:
                Console.WriteLine($"La variabile in analisi è {p}");
                break;
            case Prodotto.Olio:
                Console.WriteLine($"La variabile è {p}");
                break;
            case Prodotto.Mela:
                Console.WriteLine($"La variabile è {p}");
                break;
        }
    }
}