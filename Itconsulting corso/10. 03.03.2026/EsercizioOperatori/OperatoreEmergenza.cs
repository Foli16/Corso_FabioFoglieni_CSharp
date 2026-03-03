class OperatoreEmergenza : Operatore
{
    private int livelloUrgenza;

    public int LivelloUrgenza
    {
        get
        {
            return livelloUrgenza;
        }
        set
        {
            if(value >= 1 && value <= 5)
            {
                livelloUrgenza = value;
            }
        }
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Gestione emergenza di livello {livelloUrgenza}");
    }
}