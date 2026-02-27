class Program
{
    public static void Main()
    {
        // SPIEGAZIONE
        
        // Istanziamento di oggetto
        Cane mioCane = new Cane();

        // Cambio di stato
        mioCane.nome = "Dio";
        mioCane.eta = 1000000000;

        mioCane.Abbaia();
        mioCane.Descriviti();

        Cane mioCane2 = new Cane();

        mioCane2.nome = "Anubi";
        mioCane2.eta = 5000;

        mioCane2.Abbaia();
        mioCane2.Descriviti();

        if(ConfrontaEta(mioCane.eta, mioCane2.eta))
            Console.WriteLine($"{mioCane.nome} è più vecchio di {mioCane2.nome}");
        else
            Console.WriteLine($"{mioCane.nome} è più giovane di {mioCane2.nome}");

        CambiaNome(ref mioCane.nome);
        Console.WriteLine($"Nuovo nome: {mioCane.nome}");

        Persona p = new Persona("Gianni Morandi", 70000);
        Console.WriteLine($"Persona di nome {p.nome} e di anni {p.eta}");

        // ESERCIZIO 1
        Studente s1 = new Studente();
        s1.name = "Gianpiero";
        s1.matricola = 12345;
        s1.mediaVoti = 8.5;

        Studente s2 = new Studente();
        s2.name = "Geraldo";
        s2.matricola = 45678;
        s2.mediaVoti = 6.7;

        s1.Info();
        s2.Info();

        // ESERCIZIO 2
        Persona p1 = new Persona("Gino", "Paoli", 1940);
        Persona p2 = new Persona("Jar Jar", "Binks", 1970);
        p1.Presentazione();
        p2.Presentazione();

        // ESERCIZIO 3
        Operazioni o = new Operazioni();
        Console.WriteLine("Inserisci due numeri interi:");
        int n1 = int.Parse(Console.ReadLine()!);
        int n2 = int.Parse(Console.ReadLine()!);

        o.StampaRisultato("somma", o.Somma(n1,n2));
        o.StampaRisultato("moltiplicazione", o.Moltiplica(n1,n2));
    }

    public static bool ConfrontaEta(int eta1, int eta2)
    {
        return eta1 > eta2;
    }

    public static void CambiaNome(ref string nome)
    {
        nome = "Peppino";
    }
}