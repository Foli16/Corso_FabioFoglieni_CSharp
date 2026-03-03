class OperatoreSicurezza : Operatore
{
    private string? areaSorvegliata;

    public string? AreaSorvegliata
    {
        get
        {
            return areaSorvegliata;
        }
        set
        {
            areaSorvegliata = value;
        }
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Sorveglianza dell'area {areaSorvegliata}");
    }
}