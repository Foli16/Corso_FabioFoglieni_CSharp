using System;

class Program
{
    static void Main()
    {
        Dictionary<int, VoloAereo> voli = new Dictionary<int, VoloAereo>();
        bool continua = true;

        while(continua)
        {
            Console.WriteLine("\nChe operazione vuoi effettuare?");
            Console.WriteLine("1. Prenota\n2. Annulla\n3. Inserisci nuovo volo\n4. Esci");
            Console.Write("Seleziona comando: ");
            string risp = Console.ReadLine()!;
            switch(risp)
            {
                case "1":
                    Console.Write("Digita il codice del volo per cui vuoi effettuare l'operazione: ");
                    int keyP = int.Parse(Console.ReadLine()!);
                    if(!voli.ContainsKey(keyP))
                    {
                        Console.WriteLine("Non esistono voli con questo codice.");
                        break;
                    }
                    VoloAereo vp = voli[keyP];
                    Console.Write("\nInserisci numero posti da prenotare: ");
                    vp.EffettuaPrenotazione(int.Parse(Console.ReadLine()!));
                    Console.WriteLine($"\nStato volo numero {vp.GetCodiceVolo()}:");
                    vp.VisualizzaStato();
                    break;
                case "2":
                    Console.Write("Digita il codice del volo per cui vuoi effettuare l'operazione: ");
                    int keyA = int.Parse(Console.ReadLine()!);
                    if(!voli.ContainsKey(keyA))
                    {
                        Console.WriteLine("Non esistono voli con questo codice.");
                        break;
                    }
                    VoloAereo va = voli[keyA];
                    Console.Write("\nInserisci numero posti da annullare: ");
                    va.AnnullaPrenotazione(int.Parse(Console.ReadLine()!));
                    Console.WriteLine($"\nStato volo numero {va.GetCodiceVolo()}:");
                    va.VisualizzaStato();
                    break;
                case "3":
                    Console.Write("Inserisci codice volo: ");
                    VoloAereo v = new VoloAereo(int.Parse(Console.ReadLine()!));
                    if(voli.ContainsKey(v.GetCodiceVolo()))
                    {
                        Console.WriteLine("Codice volo già presente.");
                        break;
                    }
                    voli.Add(v.GetCodiceVolo(), v);
                    Console.WriteLine("\nVolo aggiunto. Stato iniziale:");
                    v.VisualizzaStato();
                    break;
                case "4":
                    continua = false;
                    break;
                default:
                    Console.WriteLine("\nComando invalido.");
                    break;
            }
        }
        Console.WriteLine("\nTermino programma.");
    }
}