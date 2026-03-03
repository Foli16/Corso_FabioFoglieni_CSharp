class OperatoreLogistica : Operatore
{
    private int numeroConsegne;

    public int NumeroConsegne
    {
        get
        {
            return numeroConsegne;
        }
        set
        {
            if(value >= 0)
            {
                numeroConsegne = value;
            }
        }
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Coordinamento di {numeroConsegne} consegne");
    }
}