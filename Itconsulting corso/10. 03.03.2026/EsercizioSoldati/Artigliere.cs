class Artigliere : Soldato
{
    private int calibro;

    public int Calibro
    {
        get
        {
            return calibro;
        }
        set
        {
            if(value > 0)
                calibro = value;
        }
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($", {GetType()}, calibro gestito: {calibro}");
    }
}