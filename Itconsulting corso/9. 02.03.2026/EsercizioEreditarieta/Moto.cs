class Moto : Veicolo
{
    public string? tipoManubrio;

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($"Tipo manubrio: {tipoManubrio}");
    }
}