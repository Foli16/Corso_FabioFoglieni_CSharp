public class Program
{
    static List<string> logs = new List<string>();
    static Dictionary<long, Dipendente> dipendenti = new Dictionary<long, Dipendente>();
    static void Main()
    {
        Init();

        bool continua = true;

        while(continua)
        {
            Console.WriteLine("\nMenu gestionale:");
            Console.WriteLine("1. Timbra");
            Console.WriteLine("2. Esce");
            Console.WriteLine("3. Visualizza log");
            Console.WriteLine("4. Visualizza turni dipendente");
            Console.WriteLine("0. Termina programma");
            Console.Write("Selezione: ");

            switch(Console.ReadLine())
            {
                case "1":
                    Dipendente de = RicercaDipendente();
                    if(de == null)
                        break;
                    de.Entra();
                    GestioneLog(de, DateTime.Now, true);
                    Console.WriteLine($"\n{de.Nome} {de.Cognome} è entrato.");
                    break;
                case "2":
                    Dipendente du = RicercaDipendente();
                    if(du == null)
                        break;
                    du.Esce();
                    GestioneLog(du, DateTime.Now, false);
                    Console.WriteLine($"\n{du.Nome} {du.Cognome} è uscito.");
                    break;
                case "3":
                    Console.WriteLine("\nLog entrate e uscite:");
                    foreach(string l in logs)
                    {
                        Console.WriteLine(l);
                    }
                    break;
                case "4":
                    Dipendente dt = RicercaDipendente();
                    if(dt == null)
                        break;
                    Console.WriteLine($"\nTurni del dipendente {dt.Nome} {dt.Cognome}:");
                    foreach(Turno t in dt.Turni)
                    {
                        Console.WriteLine($"Giorno -> {t.Ingresso.Day}/{t.Ingresso.Month}/{t.Ingresso.Year}:");
                        Console.WriteLine($"\tIngresso ore {t.Ingresso.TimeOfDay}");
                        Console.WriteLine($"\tUscita ore {t.Uscita.TimeOfDay}\n");
                    }
                    break;
                case "0":
                    continua = false;
                    Console.WriteLine("\nTermino programma.");
                    break;
                default:
                    Console.WriteLine("\nComando non valido.");
                    break;
            }
        }
    }

    static void Init()
    {
        Badge b1 = new Badge(123, new DateOnly(2024,12,16));
        Badge b2 = new Badge(456, new DateOnly(2020,10,10));
        Badge b3 = new Badge(789, new DateOnly(2012,9,1));
        Badge b4 = new Badge(111, new DateOnly(2013,2,10));
        Badge b5 = new Badge(323, new DateOnly(2009,1,1));
        Impiegato p1 = new Impiegato(b1, "Carlo", "Pravettoni", new DateOnly(1998,12,16), Ufficio.Tecnico);
        Impiegato p2 = new Impiegato(b2, "Carlo", "Panettoni", new DateOnly(1998,12,16), Ufficio.BackOffice);
        Impiegato p3 = new Impiegato(b3, "Carlo", "Depravatoni", new DateOnly(1998,12,16), Ufficio.Amministrazione);
        Operaio o4 = new Operaio(b4, "Carlo", "Panettiere", new DateOnly(1998,12,16), Officina.Capannone1, "Metalmeccanico");
        Operaio o5 = new Operaio(b5, "Carlo", "Laseroni", new DateOnly(1998,12,16), Officina.Capannone2, "Laserista");
        dipendenti.Add(p1.Badge!.Id, p1);
        dipendenti.Add(p2.Badge!.Id, p2);
        dipendenti.Add(p3.Badge!.Id, p3);
        dipendenti.Add(o4.Badge!.Id, o4);
        dipendenti.Add(o5.Badge!.Id, o5);
    }

    static void GestioneLog(Dipendente d, DateTime ora, bool entra)
    {
        if(entra)
            logs.Add($"- Ingresso dipendente {d.Nome} {d.Cognome} con id badge {d.Badge?.Id}: {ora}");
        else
            logs.Add($"- Uscita dipendente {d.Nome} {d.Cognome} con id badge {d.Badge?.Id}: {ora}");
    }

    static Dipendente RicercaDipendente()
    {
        Console.Write("\nRicerca dipendente tramite ID badge: ");
        long id = int.Parse(Console.ReadLine()!);
        if(dipendenti.TryGetValue(id, out Dipendente? dipendente))
        {
            return dipendente;
        }
        Console.WriteLine("Non esistono dipendenti con questo badge. Torno al menu.");
        return null!;
    }
}