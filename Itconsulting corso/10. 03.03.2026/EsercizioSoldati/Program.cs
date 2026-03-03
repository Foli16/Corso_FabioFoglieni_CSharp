using System;

class Program
{
    static void Main()
    {
        Esercito esercito = new Esercito();

        bool continua = true;

        while(continua)
        {
            Console.WriteLine("\nChe operazione vuoi effettuare?");
            Console.WriteLine("1. Aggiungi fante\n2. Aggiungi artigliere\n3. Visualizza tutti i soldati\n4. Esci");
            Console.Write("Seleziona comando: ");
            string risp = Console.ReadLine()!;
            switch(risp)
            {
                case "1":
                    Console.WriteLine("\nForm di inserimento fante\n");
                    Fante f = new Fante();
                    Console.Write("Nome: ");
                    f.Nome = Console.ReadLine()!;
                    Console.Write("Grado: ");
                    f.Grado = Console.ReadLine()!;
                    Console.Write("Anni di servizio: ");
                    int anniServizioF;
                    while(!int.TryParse(Console.ReadLine()!, out anniServizioF) || anniServizioF < 0)
                    {
                        Console.Write("Valore non valido. Inserire un numero positivo: ");
                    }
                    f.AnniServizio = anniServizioF;
                    Console.Write("Arma in dotazione: ");
                    f.Arma = Console.ReadLine()!;
                    Console.WriteLine("Confermi l'inserimento di questi dati? (s/n)");
                    if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                    {
                        esercito.Soldati.Add(f);
                        Console.WriteLine("\nFante aggiunto alla lista!");
                        break;
                    }
                    Console.WriteLine("Annullo inserimento.");
                    break;
                case "2":
                    Console.WriteLine("\nForm di inserimento artigliere\n");
                    Artigliere a = new Artigliere();
                    Console.Write("Nome: ");
                    a.Nome = Console.ReadLine()!;
                    Console.Write("Grado: ");
                    a.Grado = Console.ReadLine()!;
                    Console.Write("Anni di servizio: ");
                    int anniServizioA;
                    while(!int.TryParse(Console.ReadLine()!, out anniServizioA) || anniServizioA < 0)
                    {
                        Console.Write("Valore non valido. Inserire un numero positivo: ");
                    }
                    a.AnniServizio = anniServizioA;
                    Console.Write("Calibro gestito: ");
                    int calibro;
                    while(!int.TryParse(Console.ReadLine()!, out calibro) || calibro <= 0)
                    {
                        Console.Write("Valore non valido. Inserire un numero positivo: ");
                    }
                    a.Calibro = calibro;
                    Console.WriteLine("Confermi l'inserimento di questi dati? (s/n)");
                    if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                    {
                        esercito.Soldati.Add(a);
                        Console.WriteLine("\nArtigliere aggiunto alla lista!");
                        break;
                    }
                    Console.WriteLine("Annullo inserimento.");
                    break;
                case "3":
                    Console.WriteLine("\nEcco l'elenco completo dei soldati:");
                    if(esercito.Soldati.Count == 0)
                    {
                        Console.WriteLine("\nNessun soldato presente in lista.");
                        break;
                    }
                    foreach(Soldato s in esercito.Soldati)
                        s.Descrizione();
                    break;
                case "4":
                    continua = false;
                    Console.WriteLine("\nTermino programma.");
                    break;
                default:
                    Console.WriteLine("\nComando invalido.");
                    break;
            }
        }
    }
}