using System;

class Program
{
    static void Main()
    {
        List<Corso> corsi = new List<Corso>();

        bool continua = true;

        while(continua)
        {
            Console.WriteLine("\nMenu interattivo scuola artistica:");
            Console.WriteLine("1. Aggiungi un corso di Musica\n2. Aggiungi un corso di Pittura\n3. Aggiungi un corso di Danza\n4. Aggiungi studente ad un corso\n5. Visualizza tutti i corsi\n6. Cerca corsi per nome docente\n7. Esegui metodo speciale di un corso\n0. Esci\n");
            Console.Write("Seleziona comando: ");
            string risp = Console.ReadLine()!;
            Console.WriteLine();

            switch(risp)
            {
                case "1":
                    Console.WriteLine("Form di inserimento corso di musica\n");
                    CorsoMusica cm = new CorsoMusica();
                    Console.Write("Inserisci nome corso: ");
                    cm.nomeCorso = Console.ReadLine()!;
                    Console.Write("Inserisci durata in ore: ");
                    cm.durataOre = int.Parse(Console.ReadLine()!);
                    Console.Write("Inserisci nome docente: ");
                    cm.docente = Console.ReadLine()!;
                    Console.Write("Inserisci strumento insegnato: ");
                    cm.strumento = Console.ReadLine()!;
                    Console.WriteLine("Questi sono i dati inseriti:");
                    Console.WriteLine(cm);
                    Console.WriteLine("Confermi l'inserimento? (s/n)");
                    if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                    {
                        corsi.Add(cm);
                        Console.WriteLine("Corso aggiunto!");
                        break;
                    }
                    Console.WriteLine("\nAnnullo inserimento.");
                    break;
                case "2":
                    Console.WriteLine("Form di inserimento corso di pittura\n");
                    CorsoPittura cp = new CorsoPittura();
                    Console.Write("Inserisci nome corso: ");
                    cp.nomeCorso = Console.ReadLine()!;
                    Console.Write("Inserisci durata in ore: ");
                    cp.durataOre = int.Parse(Console.ReadLine()!);
                    Console.Write("Inserisci nome docente: ");
                    cp.docente = Console.ReadLine()!;
                    Console.Write("Inserisci tecnica insegnata: ");
                    cp.tecnica = Console.ReadLine()!;
                    Console.WriteLine("Questi sono i dati inseriti:");
                    Console.WriteLine(cp);
                    Console.WriteLine("Confermi l'inserimento? (s/n)");
                    if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                    {
                        corsi.Add(cp);
                        Console.WriteLine("Corso aggiunto!");
                        break;
                    }
                    Console.WriteLine("\nAnnullo inserimento.");
                    break;
                case "3":
                    Console.WriteLine("Form di inserimento corso di danza\n");
                    CorsoDanza cd = new CorsoDanza();
                    Console.Write("Inserisci nome corso: ");
                    cd.nomeCorso = Console.ReadLine()!;
                    Console.Write("Inserisci durata in ore: ");
                    cd.durataOre = int.Parse(Console.ReadLine()!);
                    Console.Write("Inserisci nome docente: ");
                    cd.docente = Console.ReadLine()!;
                    Console.Write("Inserisci stile insegnato: ");
                    cd.stile = Console.ReadLine()!;
                    Console.WriteLine("Questi sono i dati inseriti:");
                    Console.WriteLine(cd);
                    Console.WriteLine("Confermi l'inserimento? (s/n)");
                    if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                    {
                        corsi.Add(cd);
                        Console.WriteLine("Corso aggiunto!");
                        break;
                    }
                    Console.WriteLine("\nAnnullo inserimento.");
                    break;
                case "4":
                    if(corsi.Count == 0)
                    {
                        Console.WriteLine("Non ci sono corsi in elenco al momento.");
                        break;
                    }
                    Console.WriteLine("Elenco corsi tra cui scegliere:");
                    for (int i = 0; i < corsi.Count; i++)
                    {
                        Console.Write($"\t{i+1}. {corsi[i].nomeCorso}\n\t");
                        corsi[i].MetodoSpeciale();
                    }
                    Console.Write("\nSeleziona corso tramite indice: ");
                    int indice = int.Parse(Console.ReadLine()!)-1;
                    Corso c = corsi[indice];

                    Console.WriteLine("\nForm di inserimento studente\n");
                    Console.Write("Nome studente: ");
                    string nStud = Console.ReadLine()!;
                    Console.WriteLine($"Confermi inserimento di {nStud} nel corso? (s/n)");
                    if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                    {
                        c.AggiungiStudente(nStud);
                        Console.WriteLine("Studente aggiunto!");
                        break;
                    }
                    Console.WriteLine("Annullo inserimento.");
                    break;
                case "5":
                    if(corsi.Count == 0)
                    {
                        Console.WriteLine("Non ci sono corsi in elenco al momento.");
                        break;
                    }
                    Console.WriteLine("Ecco l'elenco completo dei corsi:");
                    foreach(Corso co in corsi)
                    {
                        Console.WriteLine($"\t{co.GetType()}");
                        Console.Write(co);
                        Console.WriteLine("\t- Studenti:");
                        foreach(string s in co.studenti)
                            Console.WriteLine($"\t\t- {s}");
                    }
                    break;
                case "6":
                    if(corsi.Count == 0)
                    {
                        Console.WriteLine("Non ci sono corsi in elenco al momento.");
                        break;
                    }
                    Console.Write("Inserisci nome docente: ");
                    string docente = Console.ReadLine()!;
                    Console.WriteLine($"Ecco l'elenco dei corsi offerti da {docente}:");
                    foreach(Corso cr in corsi)
                        if(string.Equals(cr.docente?.ToLower(), docente.ToLower()))
                            Console.WriteLine(cr);
                    break;
                case "7":
                    if(corsi.Count == 0)
                    {
                        Console.WriteLine("Non ci sono corsi in elenco al momento.");
                        break;
                    }
                     Console.WriteLine("Elenco corsi tra cui scegliere:");
                    for (int i = 0; i < corsi.Count; i++)
                    {
                        Console.WriteLine($"\t{i+1}. {corsi[i].nomeCorso}\n\t");
                    }
                    Console.Write("Seleziona corso tramite indice: ");
                    int indiceS = int.Parse(Console.ReadLine()!)-1;
                    Console.WriteLine($"Metodo speciale corso:");
                    corsi[indiceS].MetodoSpeciale();
                    break;
                case "0":
                    continua = false;
                    Console.WriteLine("Termino programma.\n");
                    break;
                default:
                Console.WriteLine("Comando non valido!\n");
                    break;
            }
        }
    }
}