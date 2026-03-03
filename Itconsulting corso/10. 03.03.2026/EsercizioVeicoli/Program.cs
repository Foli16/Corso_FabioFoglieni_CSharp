class Program
{
    static void Main()
    {
        List<Veicolo> veicoli = new List<Veicolo>();

        Auto a = new Auto("AA 123 AA");
        Moto m = new Moto("ER 07008");
        Camion c = new Camion("HR 531 MR");
        Veicolo tipoFormale1 = new Auto("Targa di prova");
        Veicolo tipoFormale2 = new Moto("Targa di prova 2");
        tipoFormale1.Ripara();

        veicoli.Add(a);
        veicoli.Add(m);
        veicoli.Add(c);
        veicoli.Add(tipoFormale1);
        veicoli.Add(tipoFormale2);

        foreach(Veicolo v in veicoli)
        {
            Console.WriteLine($"Targa veicolo: {v.Targa}");
            v.Ripara();
            Console.WriteLine();
        }
    }
}