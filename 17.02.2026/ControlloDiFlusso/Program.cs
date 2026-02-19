using System;

class Program
{
    static void Main()
    {
        int a = 15, b = 10;

        if(a>b)
        {
            Console.WriteLine($"{a} è maggiore di {b}");
        }

        // ESERCIZIO 1
        Console.WriteLine("Quanti anni hai?");
        int age = int.Parse(Console.ReadLine());

        if(age>=18)
            Console.WriteLine("Sei maggiorenne");
        else
            Console.WriteLine("Sei minorenne");

        // ESERCIZIO 2
        Console.Write("Prezzo del prodotto: ");
        double price = double.Parse(Console.ReadLine());

        if(price > 100)
        {
            price -= price*0.1;
            Console.Write($"Nuovo prezzo: {price}");
        }

        // ESERCIZIO 3
        Console.WriteLine("Dammi tre numeri su cui calcolare una media:");
        int uno = int.Parse(Console.ReadLine()!), due = int.Parse(Console.ReadLine()!), tre = int.Parse(Console.ReadLine()!);
        float media = (uno+due+tre)/3.0f;

        Console.Write($"La media è: {media}. ");

        if(media >= 60)
            Console.WriteLine("Prova superata!");
        else
            Console.WriteLine("Prova fallita.");

        // ESERCIZIO 3 EXTRA
        if(media<10 && uno==0 || due==0 || tre==0)
            Console.WriteLine("Fai un pochino schifo...");
    }
}
