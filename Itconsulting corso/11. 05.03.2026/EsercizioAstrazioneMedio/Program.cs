public class Program
{
    // TERMINATO CON EXTRA, MANCHEREBBE UN PO' DI PULIZIA DEL CODICE...
    static List<Corso> corsi = new();
    static List<Docente> docenti = new();
    static void Main()
    {
        Init();

        bool continua = true;

        while(continua)
        {
            Console.WriteLine("Menu corsi:");
            Console.WriteLine("1. Aggiungi corso");
            Console.WriteLine("2. Stampa dettagli corsi");
            Console.WriteLine("0. Esci");
            Console.Write("Selezione: ");

            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nForm inserimento corso\n");
                    Console.WriteLine("Che tipo di corso vuoi inserire?");
                    Console.WriteLine("1. Corso in presenza");
                    Console.WriteLine("2. Corso online");
                    Console.Write("Selezione: ");
                    switch(Console.ReadLine())
                    {
                        case "1":
                            CorsoInPresenza cp = new CorsoInPresenza();
                            Console.Write("Titolo corso: ");
                            cp.Titolo = Console.ReadLine();
                            Console.Write("Durata in ore: ");
                            cp.DurataOreSet = Console.ReadLine();
                            Console.Write("Aula: ");
                            cp.Aula = Console.ReadLine();
                            Console.Write("Numero posti in aula: ");
                            cp.NumeroPosti = int.Parse(Console.ReadLine()!);
                            Console.WriteLine("Scegliere docente che svolgerà il corso:");
                            for (int i = 0; i < docenti.Count; i++)
                            {
                                Console.WriteLine($"\t{i+1}. {docenti[i].Nome}, materia: {docenti[i].Materia}");
                            }
                            Console.Write("Selezione: ");
                            Docente dp = docenti[int.Parse(Console.ReadLine()!)-1];
                            cp.Docente = dp;
                            corsi.Add(cp);
                            Console.WriteLine("Corso aggiunto!");
                            break;
                        case "2":
                            CorsoOnline co = new CorsoOnline();
                            Console.Write("Titolo corso: ");
                            co.Titolo = Console.ReadLine();
                            Console.Write("Durata in ore: ");
                            co.DurataOreSet = Console.ReadLine();
                            Console.Write("Piattaforma: ");
                            co.Piattaforma = Console.ReadLine();
                            Console.Write("Link accesso: ");
                            co.LinkAccesso = Console.ReadLine();
                            Console.WriteLine("Scegliere docente che svolgerà il corso:");
                            for (int i = 0; i < docenti.Count; i++)
                            {
                                Console.WriteLine($"\t{i+1}. {docenti[i].Nome}, materia: {docenti[i].Materia}");
                            }
                            Console.Write("Selezione: ");
                            Docente don = docenti[int.Parse(Console.ReadLine()!)-1];
                            co.Docente = don;
                            corsi.Add(co);
                            Console.WriteLine("Corso aggiunto!");
                            break;
                        default:
                            Console.WriteLine("Comando non valido. Torno al menu.");
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Dettagli di tutti i corsi:\n");
                    foreach(Corso c in corsi)
                    {
                        c.StampaDettagli();
                        Console.WriteLine();
                    }
                    break;
                case "0":
                    continua = false;
                    Console.WriteLine("Termino programma.");
                    break;
                default:
                    Console.WriteLine("Comando non valido.");
                    break;
            }
        }
    }

    static void Init()
    {
        Docente d1 = new Docente("Mirko", "Vita");
        Docente d2 = new Docente("Edoardo", "GitHub Desktop");
        docenti.Add(d1);
        docenti.Add(d2);
    }
}