using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        // ESERCIZIO 1
        List<int> interi = new List<int>();
        
        Console.WriteLine("Utente, inserisci 5 numeri interi");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Dammi numero {i+1}:");
            interi.Add(int.Parse(Console.ReadLine()!));
        }
        Console.WriteLine("Dimmi un numero di quelli precedenti da rimuovere");
        interi.Remove(int.Parse(Console.ReadLine()!));
        Console.WriteLine("Nuova lista:");
        foreach(int n in interi)
            Console.WriteLine(n);
        
        // ESERCIZIO 2
        List<int> casuali = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            casuali.Add(rnd.Next(1,101));
            Console.WriteLine($"Numero alla posizione {i+1}: {casuali[i]}");
        }

        Console.WriteLine("Dimmi un numero da cercare nella lista:");
        int daCercare = int.Parse(Console.ReadLine()!);
        bool trovato = false;
        List<int> nPari = new List<int>();
        for (int i = 0; i < casuali.Count; i++)
        {
            if(casuali[i] == daCercare)
            {
                Console.WriteLine($"Trovato! L'indice è {i}");
                trovato = true;
            }
            if(casuali[i]%2 == 0)
                nPari.Add(casuali[i]);
        }
        if(!trovato)
            Console.WriteLine("Il numero ricercato non è presente nella lista");
        
        Console.WriteLine("I numeri pari sono:");
        foreach(int n in nPari)
            Console.WriteLine(n);

        // ESERCIZIO 3
        List<int> ints = new List<int>();
        Console.WriteLine("Lista iniziale (randomica):");
        for (int i = 0; i < 15; i++)
        {
            ints.Add(rnd.Next(1,21));
            Console.WriteLine($"Numero casuale {i+1}: {ints[i]}");
        }

        List<int> intsSenzaDuplicati = new List<int>();
        foreach(int n in ints)
            if(!intsSenzaDuplicati.Contains(n))
                intsSenzaDuplicati.Add(n);

        ints = intsSenzaDuplicati;

        Console.WriteLine("\nLista intermedia (senza duplicati):");
        foreach (int n in ints)
        {
            Console.WriteLine(n);
        }

        for (int i = 0; i < ints.Count-1; i++)
        {
            for (int j = 0; j < ints.Count-1; j++)
            {
                if(ints[j] > ints[j+1])
                {
                    int provv = ints[j+1];
                    ints[j+1] = ints[j];
                    ints[j] = provv;
                }
            }
        }

        Console.WriteLine("\nLista finale (in ordine crescente):");
        foreach (int n in ints)
        {
            Console.WriteLine(n);
        }
    }
}
