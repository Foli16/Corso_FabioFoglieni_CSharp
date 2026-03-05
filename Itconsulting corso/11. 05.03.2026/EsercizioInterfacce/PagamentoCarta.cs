public class PagamentoCarta : Pagamento, IPagamento
{
    private string? circuito;

    public PagamentoCarta(string ricevente, string circuito) : base(ricevente)
    {
        Circuito = circuito;
    }

    public string? Circuito
    {
        set => circuito = value;
    }

    public void EseguiPagamento(double importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro con carta (Circuito: {circuito})");
    }

    public void MostraMetodo()
    {
        Console.WriteLine($"Saldo del debito con carta di credito nei confronti di {Ricevente}");
    }
}