class Fante : Soldato
{
    private string? arma;

    public string? Arma
    {
        get
        {
            return arma;
        }
        set
        {
            arma = value;
        }
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($", {GetType()}, arma in dotazione: {arma}");
    }
}