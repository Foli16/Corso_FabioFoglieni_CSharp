using System;

class Program
{
    static List<Operatore> operatori = new List<Operatore>();
    static void Main()
    {

        bool continua = true;

        while(continua)
        {
            Console.WriteLine("\nMenu operatori:");
            Console.WriteLine("1. Aggiungi un nuovo operatore");
            Console.WriteLine("2. Visualizza tutti gli operatori");
            Console.WriteLine("3. Fai eseguire a tutti il loro compito");
            Console.WriteLine("0. Esci");
            Console.Write("Seleziona comando: ");

            string? risp = Console.ReadLine();

            switch(risp)
            {
                case "1":
                    Console.WriteLine("\nChe tipo di operatore vuoi inserire?");
                    Console.WriteLine("1. Operatore Emergenza");
                    Console.WriteLine("2. Operatore Sicurezza");
                    Console.WriteLine("3. Operatore Logistica");
                    Console.Write("Selezione: ");
                    string? ope = Console.ReadLine();

                    switch(ope)
                    {
                        case "1":
                            Console.WriteLine("\nNuovo operatore emergenza");
                            OperatoreEmergenza oe = new OperatoreEmergenza();
                            NuovoOperatore(oe);
                            break;

                        case "2":
                            Console.WriteLine("\nNuovo operatore sicurezza");
                            OperatoreSicurezza os = new OperatoreSicurezza();
                            NuovoOperatore(os);
                            break;

                        case "3":
                            Console.WriteLine("\nNuovo operatore logistica");
                            OperatoreLogistica ol = new OperatoreLogistica();
                            NuovoOperatore(ol);
                            break;
                            
                        default:
                            Console.WriteLine("\nComando non valido.");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("\nLista completa operatori:");
                    foreach(Operatore o in operatori)
                        Console.WriteLine(o);
                    break;

                case "3":
                    Console.WriteLine("\nLista compiti di ogni operatore:");
                    foreach(Operatore o in operatori)
                    {
                        Console.Write($"\t- {o.Nome} esegue il compito: ");
                        o.EseguiCompito();
                    }
                    break;

                case "0":
                    continua = false;
                    Console.WriteLine("\nTermino programma.");
                    break;

                default:
                    Console.WriteLine("\nComando invalido.");
                    break;
            }
        }
    }

    static void NuovoOperatore(Operatore o)
    {
        Console.Write("\nInserisci nome: ");
        o.Nome = Console.ReadLine();
        Console.Write("Inserisci turno (giorno/notte): ");
        o.Turno = Console.ReadLine();
        while(o.Turno == null)
        {
            Console.Write("Il turno può essere giorno o notte, scegliere uno dei due: ");
            o.Turno = Console.ReadLine();
        }
        if(o is OperatoreSicurezza os)
            InserisciOperatoreSicurezza(os);
        else if(o is OperatoreEmergenza oe)
            InserisciOperatoreEmergenza(oe);
        else if(o is OperatoreLogistica ol)
            InserisciOperatoreLogistica(ol);
    }

    static void InserisciOperatoreSicurezza(OperatoreSicurezza os)
    {
        Console.Write("Inserisci area sorvegliata: ");
        os.AreaSorvegliata = Console.ReadLine();
        AggiungiOperatore(os);
    }

    static void InserisciOperatoreEmergenza(OperatoreEmergenza oe)
    {
        Console.Write("Inserisci livello urgenza: ");
        int livello;
        while(!int.TryParse(Console.ReadLine(), out livello) || livello < 1 || livello > 5)
        {
            Console.Write("Valore non valido. Inserire un numero da 1 a 5: ");
        }
        oe.LivelloUrgenza = livello;
        AggiungiOperatore(oe);
    }

    static void InserisciOperatoreLogistica(OperatoreLogistica ol)
    {
        Console.Write("Inserisci numero consegne: ");
        int consegne;
        while(!int.TryParse(Console.ReadLine(), out consegne) || consegne < 0)
        {
            Console.Write("Valore non valido. Inserire un numero positivo: ");
        }
        ol.NumeroConsegne = consegne;
        AggiungiOperatore(ol);
    }

    static void AggiungiOperatore(Operatore o)
    {
        Console.WriteLine("Confermi i dati inseriti? (s/n)");
        if(string.Equals(Console.ReadLine()!.ToLower(), "s"))
        {
            operatori.Add(o);
            Console.WriteLine("\nOperatore aggiunto!");
            return;
        }
        Console.WriteLine("\nAnnullo operazione.");
    }
}