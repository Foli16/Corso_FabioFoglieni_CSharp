using System;

class Program
{
    static void Main()
    {
        int a = 2, b = 9;
        Console.WriteLine($"Risultato: {Somma(a, b)}");

        
        // ESERCIZIO 1
        StampaSaluto("Lupo Lucio");

        // ESERCIZIO 2
        int numero = 11;
        Console.WriteLine($"Il numero {numero} è pari? {VerificaPari(numero)}");

        // ESERCIZIO 3
        int baseNum = 15, esponente = 5, risultato = CalcolaPotenza(baseNum, esponente);

        Console.WriteLine($"Il numero {baseNum} elevato alla potenza di {esponente} da come risultato: {risultato}");
    }

    private static int Somma(int a, int b)
    {
        return a + b;
    }

    private static void StampaSaluto(string nome)
    {
        Console.WriteLine($"Ciao bambini, sono {nome}!");
    }

    private static bool VerificaPari(int numero)
    {
        return numero % 2 == 0;
    }

    private static int CalcolaPotenza(int baseNum, int esponente)
    {
        if(baseNum == 0)
            return 1;
        int risultato = baseNum;
        for (int i = 0; i < esponente-1; i++)
            risultato *= baseNum;
        return risultato;
    }
}