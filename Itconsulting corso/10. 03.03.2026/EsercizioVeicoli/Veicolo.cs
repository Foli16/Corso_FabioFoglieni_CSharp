class Veicolo
{
    private string? targa;

    // public Veicolo(string targa)
    // {
    //     this.targa = targa;
    // }

    public string? Targa
    {
        get
        {
            return targa;
        }
        set
        {
            targa = value;
        }
    }

    public virtual void Ripara()
    {
        Console.WriteLine("Il veicolo viene controllato");
    }
}