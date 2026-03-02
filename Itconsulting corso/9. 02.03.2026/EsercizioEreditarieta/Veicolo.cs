class Veicolo
{
    public string? marca, modello;

    public virtual void StampaInfo()
    {
        Console.WriteLine($"Marca: {marca}, modello: {modello}");
    }
}