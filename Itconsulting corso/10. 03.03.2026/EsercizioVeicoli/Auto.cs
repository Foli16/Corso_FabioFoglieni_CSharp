class Auto : Veicolo
{
    public Auto(string targa)
    {
        Targa = targa;
    }

    public override void Ripara()
    {
        Console.WriteLine("Controllo olio, freni e motore dell'auto.");
    }
}