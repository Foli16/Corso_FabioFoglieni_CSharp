using System;

class Esercizi17Mattina
{
    static void Main()
    {
        // ESERCIZIO 1
        Console.WriteLine("Dammi due numeri da sommare:");
        int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
        Console.WriteLine("Somma: "+(a+b));

        // ESERCIZIO 2
        Console.WriteLine("Dammi un numero a cui applicare lo sconto del 20%:");
        double originalPrice = double.Parse(Console.ReadLine());
        Console.WriteLine("Prezzo scontato: "+originalPrice*0.2);

        // ESERCIZIO 3
        Console.WriteLine("Dammi un numero con la virgola:");
        float virgola = float.Parse(Console.ReadLine());
        Console.WriteLine("Il numero è positivo? " + (virgola>0));

        // ESERCIZIO 4
        Console.Write("Dammi un numero intero: ");
        int integer = int.Parse(Console.ReadLine());
        Console.Write("Dammi un numero con la virgola: ");
        float floattante = float.Parse(Console.ReadLine());
        Console.WriteLine("Somma: "+(integer+floattante));

        // ESERCIZIO 5
        Console.Write("Dimmi la tua età: ");
        int eta = int.Parse(Console.ReadLine());
        Console.Write("Dammi la tua altezza: ");
        float altezza = float.Parse(Console.ReadLine());
        Console.WriteLine("Somma: "+(int)(eta+altezza));

        // ESERCIZIO 6 EXTRA
        Console.WriteLine("Dammi due numeri:");
        int primo = int.Parse(Console.ReadLine()), secondo = int.Parse(Console.ReadLine());
        Console.WriteLine($"Primo minore di secondo e maggiore di 10? {primo<secondo && primo>10}");
        Console.WriteLine($"Primo minore di secondo o maggiore di 10? {primo<secondo || primo>10}");
        Console.WriteLine($"Primo NON minore di secondo? {!(primo<secondo)}");
    }
}
