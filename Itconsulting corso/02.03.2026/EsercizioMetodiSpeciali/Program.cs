using System;

class Program
{
    static void Main()
    {
        // Libro l1 = new Libro() {titolo = "Guerra e pace", autore = "Lev Tolstoj", annoPubblicazione = 1867};
        // Libro l2 = new Libro() {titolo = "Guerra e pace", autore = "Lev Tolstoj", annoPubblicazione = 1867};

        // // To String
        // Console.WriteLine(l1);
        // Console.WriteLine(l2);

        // // Equals
        // Console.WriteLine($"\nl1 è uguale a l2? {l1.Equals(l2)}");

        // // GetHashCode
        // Console.WriteLine($"\nHashCode di l1: {l1.GetHashCode()}");
        // Console.WriteLine($"HashCode di l2: {l2.GetHashCode()}");
        // Console.WriteLine($"\nL'hashcode di l1 è uguale a quello di l2? {l1.GetHashCode() == l2.GetHashCode()}");

        // // GetType
        // Console.WriteLine($"\nTipo di l1: {l1.GetType()}");
        // Console.WriteLine($"Tipo di l2: {l2.GetType()}");

        // // ReferenceEquals
        // Console.WriteLine($"\nl1 e l2 si riferiscono allo stesso oggetto? {ReferenceEquals(l1, l2)}");
        // Console.WriteLine($"\nl1.titolo e l2.titolo hanno la stessa reference? {ReferenceEquals(l1.titolo, l2.titolo)}");

        // // MemberwiseClone;
        // Libro l3 = l1.Copia();

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
                Console.WriteLine("1. Aumenta la velocità di 10\n2. Cambia tipo motore\n3. Aumenta di 1 le sospensioni,\n4. Termina modifiche");
                string risp = Console.ReadLine()!;

                switch(risp)
                {
                    case "1":
                        m.velocitaMax += 10;
                        ModificaAvvenuta(ref u.credito, ref m.nrModifiche);
                        Console.WriteLine("\nVelocità aumentata!\n");
                        break;
                    case "2":
                        bool continuaMotore = true;
                        Console.WriteLine("\nChe motore vuoi inserire?");
                        Console.WriteLine("1. Motore elettrico\n2. Motore ibrido\n3. Motore a combustione nucleare");
                        while(continuaMotore)
                        {
                            string rispMotore = Console.ReadLine()!;
                            switch(rispMotore)
                            {
                                case "1":
                                    m.motore = "Motore elettrico";
                                    continuaMotore = false;
                                    break;
                                case "2":
                                    m.motore = "Motore ibrido";
                                    continuaMotore = false;
                                    break;
                                case "3":
                                    m.motore = "Motore a combustione nucleare";
                                    continuaMotore = false;
                                    break;
                                default:
                                    Console.WriteLine("\nComando non valido! Inserire uno dei comandi disponibili.\n");
                                    break;
                            }
                        }
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