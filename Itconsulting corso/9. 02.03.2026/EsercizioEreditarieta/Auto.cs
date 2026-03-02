class Auto : Veicolo
{
    public int nPorte;

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($"Numero porte: {nPorte}");
    }
}