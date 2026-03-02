using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Inserisci nome utente numero {i+1}: ");
            string nomeU = Console.ReadLine()!;
            Utente u = new Utente(nomeU);
            Macchina m = new Macchina();

            Console.WriteLine($"\nCiao {u.nome}!\nHai a disposizione {u.credito} crediti, usali bene!\n");
            Console.WriteLine($"Caratteristiche iniziali veicolo:\n{m}\n");

            bool continua = true;

            while(continua && u.credito != 0)
            {
                Console.WriteLine("Scegli quale modifica apportare tra le seguenti:");
                Console.WriteLine("1. Aumenta la velocità di 10\n2. Cambia tipo motore\n3. Aumenta di 1 le sospensioni\n4. Termina modifiche");
                string risp = Console.ReadLine()!;

                switch(risp)
                {
                    case "1":
                        m.velocitaMax += 10;
                        ModificaAvvenuta(ref u.credito, ref m.nrModifiche);
                        Console.WriteLine("\nVelocità aumentata!\n");
                        break;
                    case "2":
                        bool continuaMotore;
                        Console.WriteLine("\nChe motore vuoi inserire?");
                        Console.WriteLine("1. Motore elettrico\n2. Motore ibrido\n3. Motore a combustione nucleare");
                        do
                        {
                            continuaMotore = false;
                            string rispMotore = Console.ReadLine()!;
                            switch(rispMotore)
                            {
                                case "1":
                                    m.motore = "Motore elettrico";
                                    break;
                                case "2":
                                    m.motore = "Motore ibrido";
                                    break;
                                case "3":
                                    m.motore = "Motore a combustione nucleare";
                                    break;
                                default:
                                    continuaMotore = true;
                                    Console.WriteLine("\nComando non valido! Inserire uno dei comandi disponibili.\n");
                                    break;
                            }
                        } while(continuaMotore);
                        ModificaAvvenuta(ref u.credito, ref m.nrModifiche);
                        Console.WriteLine("\nMotore modificato!\n");
                        break;
                    case "3":
                        m.sospensioniMax++;
                        ModificaAvvenuta(ref u.credito, ref m.nrModifiche);
                        Console.WriteLine("\nSospensioni migliorate!\n");
                        break;
                    case "4":
                        continua = false;
                        Console.WriteLine("\nModifiche terminate!\n");
                        break;
                    default:
                        Console.WriteLine("\nComando non valido!\n");
                        break;
                }
                if(u.credito == 0)
                    Console.WriteLine("Credito esaurito!\nTermino modifiche.\n");
            }
            Console.WriteLine("\nStampa caratteristiche:\n");
            Console.WriteLine($"Utente numero {i+1}");
            Console.WriteLine(u);
            Console.WriteLine("Veicolo");
            Console.WriteLine(m);
            Console.WriteLine();
        }
        Console.WriteLine("\nFine programma.\n");
    }

    private static void ModificaAvvenuta(ref int credito, ref int nrModifiche)
    {
        credito--;
        nrModifiche++;
    }
}