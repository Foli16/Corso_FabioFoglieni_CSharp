class Moto : Veicolo
{
    public Moto(string targa)
    {
        Targa = targa;
    }
    public override void Ripara()
    {
        Console.WriteLine("Controllo catena, freni e gomme della moto.");
    }
}