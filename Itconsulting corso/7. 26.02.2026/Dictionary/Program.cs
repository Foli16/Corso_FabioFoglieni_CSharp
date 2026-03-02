using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {
        // Spiegazione();

        // Esercizio1();
        Esercizio2();
        // Esercizio3();
    }

    private static void Spiegazione()
    {
        Dictionary<string, string> capitali = new Dictionary<string, string>()
        {
            {"Italia", "Roma"},
            {"Francia", "Parigi"},
            {"Spagna", "Madrid"}
        };

        // In questo modo da errore se è già presente una chiave con questo identificativo
        capitali.Add("Portogallo", "Lisbona");
        // Così invece se esiste lo sovrascrive
        capitali["Germania"] = "Berlino";

        foreach(KeyValuePair<string, string> cap in capitali)
        {
            Console.WriteLine($"{cap.Key}: {cap.Value}");
        }

        foreach(var cap in capitali) // con il var intuisce da solo il tipo
        {
            Console.WriteLine($"{cap.Key}: {cap.Value}");
        }

        Console.WriteLine($"La chiave Italia esiste? {capitali.ContainsKey("Italia")}");
        Console.WriteLine($"Il valore Roma esiste nel dictionary? {capitali.ContainsValue("Rom")}");

        capitali.Remove("Portogallo"); // restituisce un booleano

        foreach(var cap in capitali)
        {
            Console.WriteLine($"{cap.Key}: {cap.Value}");
        }

        // Accede alla coppia chiave-valore alla posizione indicata
        Console.WriteLine($"{capitali.ElementAt(0)}");

        Console.WriteLine($"Capacità: {capitali.Capacity}");

        for (int i = 0; i < capitali.Count; i++)
        {
            Console.WriteLine($"{capitali.ElementAt(i).Value}");
        }

        capitali.First();
        capitali.Last();
    }

    private static void Esercizio1()
    {
        Dictionary<string, string> numeriTelefono = new Dictionary<string, string>();

        Console.WriteLine("Inserisci 3 coppie chiave-valore");
        for (int i = 0; i < 3; i++)
        {
            numeriTelefono.Add(Console.ReadLine()!, Console.ReadLine()!);
        }

        foreach(var n in numeriTelefono)
            Console.WriteLine($"Coppia chiave-valore: {n}");
    }

    private static void Esercizio2()
    {
        Console.WriteLine("Inserisci una frase");
        string[] paroleDaFrase = Console.ReadLine()!.Split();

        Dictionary<string, int> conteggioParole = new Dictionary<string, int>();
        foreach(string p in paroleDaFrase)
            conteggioParole[p] = conteggioParole.ContainsKey(p) ? conteggioParole[p]+1 : 1;

        foreach(var kv in conteggioParole)
            Console.WriteLine(kv);
    }

    private static void Esercizio3()
    {
        Dictionary<string, int> inventario = new Dictionary<string, int>();

        int risp;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Aggiungi prodotto/Aggiorna prodotto\n2 - Rimuovi prodotto\n3 - Cerca prodotto\n4 - Stampa inventario\n5 - Esci");
            Console.Write("\nSeleziona comando: ");
            risp = int.Parse(Console.ReadLine()!);

            switch(risp)
            {
                case 1:
                    Console.WriteLine("Inserisci nome prodotto:");
                    string nomeP = Console.ReadLine()!;
                    if(!inventario.ContainsKey(nomeP))
                    {
                        Console.WriteLine("Inserisci quantità prodotto:");
                        int quantita = int.Parse(Console.ReadLine()!);
                        inventario.Add(nomeP, quantita);
                        Console.WriteLine("\nProdotto aggiunto!");
                    }
                    else
                    {
                        Console.WriteLine($"Questo prodotto esiste già. La sua quantità attuale è: {inventario[nomeP]}");
                        Console.WriteLine("Vuoi modificare la sua quantità? (y/n)");
                        if(string.Equals(Console.ReadLine()!.ToLower(), "y"))
                        {
                            Console.WriteLine("Inserisci nuova quantità:");
                            inventario[nomeP] = int.Parse(Console.ReadLine()!);
                            Console.WriteLine($"Prodotto aggiornato. Nuova quantità: {inventario[nomeP]}");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Inserisci nome del prodotto che vuoi rimuovere:");
                    string key = Console.ReadLine()!;
                    if(inventario.ContainsKey(key))
                    {
                        Console.WriteLine($"Rimuovo prodotto con nome {key} e quantità {inventario[key]}.");
                        inventario.Remove(key);
                        Console.WriteLine("Rimosso con successo.");
                    }
                    else
                        Console.WriteLine($"La chiave {key} è inesistente. Ritorno al menu.");
                    break;
                case 3:
                    Console.WriteLine("Inserisci il nome del prodotto che vuoi ricercare:");
                    string nome = Console.ReadLine()!;
                    if(inventario.ContainsKey(nome))
                    {
                        Console.WriteLine("\nEcco il prodotto ricercato:");
                        Console.WriteLine($"\t- Prodotto: {nome}, quantità: {inventario[nome]}");
                    }
                    else
                        Console.WriteLine($"Il prodotto con nome {nome} è inesistente. Ritorno al menu.");
                    break;
                case 4:
                    if(inventario.Count == 0)
                    {
                        Console.WriteLine("Inventario vuoto.");
                        break;
                    }
                    Console.WriteLine("Ecco l'inventario completo:");
                    foreach(var kv in inventario)
                        Console.WriteLine($"\t- Prodotto: {kv.Key}, quantità: {kv.Value}");
                    break;
                case 5:
                    Console.WriteLine("\nTermino programma.");
                    break;
                default:
                    Console.WriteLine("Comando non valido!");
                    break;
            }
        } while(risp != 5);
    }
}