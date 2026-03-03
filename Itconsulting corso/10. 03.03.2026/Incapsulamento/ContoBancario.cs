class ContoBancario
{
    private double saldo;

    public string? variabile { get; private set; } // SI POSSONO DICHIARARE GET O SET COME PRIVATE

    public double Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if(value >= 0)
                saldo = value;
        }
    }

    // GETTER "MANUALE"
    public double OttieniSaldo()
    {
        return saldo;
    }

    // SETTER "MANUALE"
    public void Deposita(double importo)
    {
        if(importo > 0)
            saldo += importo;
    }
}