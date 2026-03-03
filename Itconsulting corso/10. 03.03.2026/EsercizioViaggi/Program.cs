using System;

class Program
{
    static List<PrenotazioneViaggio> viaggi = new List<PrenotazioneViaggio>();
    static void Main()
    {
        Init();

        bool continua = true;

        while(continua)
        {
            Console.WriteLine("\nChe operazione vuoi effettuare?");
            Console.WriteLine("1. Prenota\n2. Annulla\n3. Esci");
            Console.Write("Seleziona comando: ");
            string risp = Console.ReadLine()!;
            switch(risp)
            {
                case "1":
                    Console.WriteLine("\nScegli destinazione tra quelle elencate:");
                    for (int i = 0; i < viaggi.Count; i++)
                    {
                        Console.WriteLine($"Destinazione viaggio {i+1}: {viaggi[i].Destinazione}");
                    }
                    Console.Write("Seleziona prenotazione: ");
                    int indiceP = int.Parse(Console.ReadLine()!)-1;
                    PrenotazioneViaggio vp = viaggi[indiceP];
                    Console.Write("\nInserisci numero posti da prenotare: ");
                    vp.PrenotaPosti(int.Parse(Console.ReadLine()!));
                    Console.WriteLine($"Stato prenotazione:\nDestinazione: {vp.Destinazione}, posti occupati: {vp.PostiPrenotati}, posti liberi: {vp.PostiDisponibili}");
                    break;
                case "2":
                    Console.WriteLine("\nScegli destinazione tra quelle elencate:");
                    for (int i = 0; i < viaggi.Count; i++)
                    {
                        Console.WriteLine($"Destinazione viaggio {i+1}: {viaggi[i].Destinazione}");
                    }
                    Console.Write("Seleziona prenotazione: ");
                    int indiceA = int.Parse(Console.ReadLine()!)-1;
                    PrenotazioneViaggio va = viaggi[indiceA];
                    Console.Write("\nInserisci numero posti da annullare: ");
                    va.AnnullaPrenotazione(int.Parse(Console.ReadLine()!));
                    Console.WriteLine($"Stato prenotazione:\nDestinazione: {va.Destinazione}, posti occupati: {va.PostiPrenotati}, posti liberi: {va.PostiDisponibili}");
                    break;
                case "3":
                    continua = false;
                    break;
                default:
                    Console.WriteLine("\nComando invalido.");
                    break;
            }
        }
        Console.WriteLine("\nTermino programma.");
    }

    static void Init()
    {
        PrenotazioneViaggio p1 = new PrenotazioneViaggio();
        p1.Destinazione = "Bali";
        p1.SetCodiceVolo(1234);
        viaggi.Add(p1);
        PrenotazioneViaggio p2 = new PrenotazioneViaggio();
        p2.Destinazione = "Casablanca";
        p2.SetCodiceVolo(1235);
        viaggi.Add(p2);
        PrenotazioneViaggio p3 = new PrenotazioneViaggio();
        p3.Destinazione = "Parigi";
        p3.SetCodiceVolo(1236);
        viaggi.Add(p3);
    }
}