using System;

class Program
{
    static void Main()
    {
        List<Veicolo> veicoli = new List<Veicolo>();

        bool continua = true;


        while(continua)
        {
            Console.WriteLine("Menu gestione veicoli:");
            Console.WriteLine("1. Inserisci nuovo veicolo\n2. Visualizza tutti i veicoli\n3. Esci");
            Console.Write("Selezione comando: ");
            string risp = Console.ReadLine()!;
            switch(risp)
            {
                case "1":
                    bool tornaMenu = false;
                    while(!tornaMenu)
                    {
                        Console.WriteLine("Che tipo di veicolo vuoi inserire? (auto/moto)");
                        string rispVeicolo = Console.ReadLine()!;
                        if(string.Equals(rispVeicolo.ToLower(), "auto"))
                        {
                            Auto a = new Auto();
                            Console.Write("Modello auto: ");
                            a.modello = Console.ReadLine()!;
                            Console.Write("Marca auto: ");
                            a.marca = Console.ReadLine()!;
                            Console.Write("Numero porte: ");
                            a.nPorte = int.Parse(Console.ReadLine()!);
                            veicoli.Add(a);
                            Console.WriteLine("Auto aggiunta!");
                            tornaMenu = true;
                        }
                        else if(string.Equals(rispVeicolo.ToLower(), "moto"))
                        {
                            Moto m = new Moto();
                            Console.Write("Modello moto: ");
                            m.modello = Console.ReadLine()!;
                            Console.Write("Marca moto: ");
                            m.marca = Console.ReadLine()!;
                            Console.Write("Tipo manubrio moto: ");
                            m.tipoManubrio = Console.ReadLine()!;
                            veicoli.Add(m);
                            Console.WriteLine("Moto aggiunta!");
                            tornaMenu = true;
                        }
                        else
                        {
                            Console.WriteLine("Veicolo non valido.");
                        }
                    }
                    break;
                case "2":
                    foreach(Veicolo v in veicoli)
                        v.StampaInfo();
                    break;
                case "3":
                    continua = false;
                    Console.WriteLine("Termino programma.");
                    break;
                default:
                    Console.WriteLine("Comando non valido.");
                    break;
            }
        }
    }
}