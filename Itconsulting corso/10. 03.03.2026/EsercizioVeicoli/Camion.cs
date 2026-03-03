class Camion : Veicolo
{
    public Camion(string targa)
    {
        Targa = targa;
    }

    public override void Ripara()
    {
        Console.WriteLine("Controllo sospensioni, freni rinforzati e carico del camion.");
    }
}