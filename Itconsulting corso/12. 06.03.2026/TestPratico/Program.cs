public class Program
{
    // TERMINATO MA NON HO FATTO IN TEMPO A RENDERLO PIU' PULITO E COMMENTATO
    static void Main()
    {
        List<Animale> animali = new List<Animale>();

        bool continua = true;

        while(continua)
        {
            Console.WriteLine("\nMenu fattoria:");
            Console.WriteLine("1. Aggiungi animale");
            Console.WriteLine("2. Modifica animale");
            Console.WriteLine("3. Elimina animale");
            Console.WriteLine("4. Stampa info animali");
            Console.WriteLine("0. Esci");
            Console.Write("Selezione: ");

            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nForm inserimento animale\n");
                    Console.WriteLine("Che tipo di animale vuoi inserire?");
                    Console.WriteLine("1. Gallina");
                    Console.WriteLine("2. Mucca");
                    Console.WriteLine("3. Pecora");
                    Console.Write("Selezione: ");
                    switch(Console.ReadLine())
                    {
                        case "1":
                            Gallina g = new Gallina();
                            Console.Write("Nome: ");
                            g.Nome = Console.ReadLine();
                            Console.Write("Età: ");
                            g.Eta = int.Parse(Console.ReadLine()!);
                            Console.Write("Uova deposte ultima volta: ");
                            g.UovaDeposte = int.Parse(Console.ReadLine()!);
                            Console.WriteLine("Confermi i dati inseriti? (s/n)");
                            if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                            {
                                animali.Add(g);
                                Console.WriteLine("Gallina aggiunta!");
                                break;
                            }
                            Console.WriteLine("Annullo inserimento.");
                            break;
                        case "2":
                            Mucca m = new Mucca();
                            Console.Write("Nome: ");
                            m.Nome = Console.ReadLine();
                            Console.Write("Età: ");
                            m.Eta = int.Parse(Console.ReadLine()!);
                            Console.Write("Colore macchie: ");
                            m.ColoreMacchie = Console.ReadLine()!;
                            Console.WriteLine("Confermi i dati inseriti? (s/n)");
                            if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                            {
                                animali.Add(m);
                                Console.WriteLine("Mucca aggiunta!");
                                break;
                            }
                            Console.WriteLine("Annullo inserimento.");
                            break;
                        case "3":
                            Pecora p = new Pecora();
                            Console.Write("Nome: ");
                            p.Nome = Console.ReadLine();
                            Console.Write("Età: ");
                            p.Eta = int.Parse(Console.ReadLine()!);
                            Console.Write("È tosata? (s/n) ");
                            if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                                p.Tosata = true;
                            Console.WriteLine("Confermi i dati inseriti? (s/n)");
                            if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                            {
                                animali.Add(p);
                                Console.WriteLine("Pecora aggiunta!");
                                break;
                            }
                            Console.WriteLine("Annullo inserimento.");
                            break;
                        default:
                            Console.WriteLine("Comando non valido. Torno al menu.");
                            break;
                    }
                    break;
                case "2":
                    if(animali.Count == 0)
                    {
                        Console.WriteLine("Non ci sono animali in fattoria.");
                        break;
                    }
                    Console.WriteLine("\nInserisci l'indice dell'animale che vuoi modificare tra i seguenti:");
                    for (int i = 0; i < animali.Count; i++)
                    {
                        Console.WriteLine($"{i+1}. {animali[i].Nome}, {animali[i].GetType()}");
                    }
                    Console.WriteLine("Selezione: ");
                    Animale am = animali[int.Parse(Console.ReadLine()!)-1];
                    bool continuaM = true;
                    while(continuaM)
                    {
                        if(am is Mucca m)
                        {
                            Console.WriteLine("\nQuale caratteristica vuoi modificare?");
                            Console.WriteLine("1. Nome");
                            Console.WriteLine("2. Età");
                            Console.WriteLine("3. Colore macchie");
                            Console.WriteLine("0. Termina modifiche");
                            Console.Write("Selezione: ");
                            switch(Console.ReadLine()!)
                            {
                                case "1":
                                    Console.Write("Nuovo nome: ");
                                    m.Nome = Console.ReadLine()!;
                                    Console.WriteLine("Nome modificato!\n");
                                    break;
                                case "2":
                                    Console.Write("Nuova età: ");
                                    m.Eta = int.Parse(Console.ReadLine()!);
                                    Console.WriteLine("Età modificata!\n");
                                    break;
                                case "3":
                                    Console.Write("Nuovo colore: ");
                                    m.ColoreMacchie = Console.ReadLine()!;
                                    Console.WriteLine("Colore modificato!\n");
                                    break;
                                case "0":
                                    continuaM = false;
                                    Console.WriteLine("Torno al menu.\n");
                                    break;
                                default:
                                    Console.WriteLine("Comando non valido.");
                                    break;
                            }
                        }
                        else if(am is Gallina g)
                        {
                            Console.WriteLine("Quale caratteristica vuoi modificare?");
                            Console.WriteLine("1. Nome");
                            Console.WriteLine("2. Età");
                            Console.WriteLine("3. Uova deposte");
                            Console.WriteLine("0. Termina modifiche");
                            Console.Write("Selezione: ");
                            switch(Console.ReadLine()!)
                            {
                                case "1":
                                    Console.Write("Nuovo nome: ");
                                    g.Nome = Console.ReadLine()!;
                                    Console.WriteLine("Nome modificato!\n");
                                    break;
                                case "2":
                                    Console.Write("Nuova età: ");
                                    g.Eta = int.Parse(Console.ReadLine()!);
                                    Console.WriteLine("Età modificata!\n");
                                    break;
                                case "3":
                                    Console.Write("Nuovo colore: ");
                                    g.UovaDeposte = int.Parse(Console.ReadLine()!);
                                    Console.WriteLine("Uova modificate!\n");
                                    break;
                                case "0":
                                    continuaM = false;
                                    Console.WriteLine("Torno al menu.\n");
                                    break;
                                default:
                                    Console.WriteLine("Comando non valido.");
                                    break;
                            }
                        }
                        else if(am is Pecora p)
                        {
                            Console.WriteLine("Quale caratteristica vuoi modificare?");
                            Console.WriteLine("1. Nome");
                            Console.WriteLine("2. Età");
                            Console.WriteLine("3. Uova deposte");
                            Console.WriteLine("0. Termina modifiche");
                            Console.Write("Selezione: ");
                            switch(Console.ReadLine()!)
                            {
                                case "1":
                                    Console.Write("Nuovo nome: ");
                                    p.Nome = Console.ReadLine()!;
                                    Console.WriteLine("Nome modificato!\n");
                                    break;
                                case "2":
                                    Console.Write("Nuova età: ");
                                    p.Eta = int.Parse(Console.ReadLine()!);
                                    Console.WriteLine("Età modificata!\n");
                                    break;
                                case "3":
                                    Console.Write("È tosata? (s/n) ");
                                    if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
                                        p.Tosata = true;
                                    Console.WriteLine("Tosatura modificate!\n");
                                    break;
                                case "0":
                                    continuaM = false;
                                    Console.WriteLine("Torno al menu.\n");
                                    break;
                                default:
                                    Console.WriteLine("Comando non valido.");
                                    break;
                            }
                        }
                    }
                    break;
                case "3":
                    if(animali.Count == 0)
                    {
                        Console.WriteLine("\nNon ci sono animali in fattoria.");
                        break;
                    }
                    Console.WriteLine("\nInserisci l'indice dell'animale che vuoi eliminare tra i seguenti:");
                    for (int i = 0; i < animali.Count; i++)
                    {
                        Console.WriteLine($"{i+1}. {animali[i].Nome}, {animali[i].GetType()}");
                    }
                    Console.WriteLine("Selezione: ");
                    animali.RemoveAt(int.Parse(Console.ReadLine()!)-1);
                    Console.WriteLine("Animale rimosso dalla fattoria.");
                    break;
                case "4":
                    if(animali.Count == 0)
                    {
                        Console.WriteLine("\nNon ci sono animali in fattoria.");
                        break;
                    }
                    Console.WriteLine("\nEcco la lista completa degli animali:");
                    foreach(Animale a in animali)
                    {
                        a.StampaInfo();
                        a.FaiVerso();
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
}