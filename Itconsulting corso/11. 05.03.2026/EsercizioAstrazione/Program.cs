public class Program
{
    static void Main()
    {
        List<DispositivoElettronico> disps = new List<DispositivoElettronico>();

        DispositivoElettronico d1 = new Computer("HP SuperComputer Quantistico");
        DispositivoElettronico d2 = new Stampante("Epson WF-10000 StampaUmani");

        disps.Add(d1);
        disps.Add(d2);

        foreach(DispositivoElettronico d in disps)
        {
            d.MostraInfo();
            d.Accendi();
            d.Spegni();
        }
    }
}