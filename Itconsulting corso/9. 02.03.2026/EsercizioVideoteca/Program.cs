using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {
        List<Film> films = new List<Film>();

        bool continua = true;

        Console.WriteLine("\nBenvenuto nella videoteca!");

        while(continua)
        {
            Console.WriteLine("\nSeleziona un comando tra i seguenti:");
            Console.WriteLine("1. Inserisci un film\n2. Stampa tutti i film\n3. Ricerca per genere\n4. Esci");
            Console.Write("Selezione: ");
            string risp = Console.ReadLine()!;
            switch(risp)
            {
                case "1":
                    Console.WriteLine("\nForm di inserimento film\n");
                    Film f = new Film();
                    Console.Write("Titolo: ");
                    f.titolo = Console.ReadLine()!;
                    Console.Write("Regista: ");
                    f.regista = Console.ReadLine()!;
                    Console.Write("Anno di uscita: ");
                    int annoUscita;
                    while(!int.TryParse(Console.ReadLine()!, out annoUscita))
                    {
                        Console.Write("Dato inserito non valido.\nInserire un numero intero corrispondente all'anno di uscita: ");
                    }
                    f.anno = annoUscita;
                    Console.Write("Genere: ");
                    f.genere = Console.ReadLine()!;
                    Console.WriteLine($"\nQuesti sono i dati inseriti:\n{f}\nConfermi l'inserimento in catalogo? (s/n)");
                    if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                    {
                        films.Add(f);
                        Console.WriteLine("\nFilm aggiunto al catalogo!");
                        break;
                    }
                    Console.WriteLine("\nAnnullo inserimento.");
                    break;
                case "2":
                    if(films.Count == 0)
                    {
                        Console.WriteLine("\nCatalogo vuoto.");
                        break;
                    }
                    Console.WriteLine("\nEcco la lista completa dei film:");
                    foreach(Film film in films)
                        Console.WriteLine(film);
                    break;
                case "3":
                    Console.Write("\nDigitare il genere da ricercare: ");
                    string genere = Console.ReadLine()!;
                    bool trovati = false;
                    Console.WriteLine($"\nEcco la lista di film di genere {genere}:");
                    foreach(Film fi in films)
                    {
                        if(string.Equals(fi.genere?.ToLower(), genere.ToLower()))
                        {
                            Console.WriteLine(fi);
                            trovati = true;
                        }
                    }
                    if(!trovati)
                        Console.WriteLine("\n\tNon ci sono film di questo genere in catalogo.");
                    break;
                case "4":
                    continua = false;
                    Console.WriteLine("\nGrazie e arrivederci!\n");
                    break;
                default:
                    Console.WriteLine("\nComando non valido!");
                    break;
            }
        }
    }
}