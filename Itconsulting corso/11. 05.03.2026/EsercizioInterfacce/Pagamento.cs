public abstract class Pagamento
{
    private string? ricevente;

    public string? Ricevente
    {
        get
        {
            return ricevente;
        }
    }

    public Pagamento(string ricevente)
    {
        this.ricevente = ricevente;
    }
}