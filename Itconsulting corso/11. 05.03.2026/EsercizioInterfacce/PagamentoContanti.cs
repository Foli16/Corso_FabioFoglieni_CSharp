public class PagamentoContanti : Pagamento, IPagamento
{
    public PagamentoContanti(string ricevente) : base(ricevente) {}
    public void EseguiPagamento(double importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro in contanti.");
    }

    public void MostraMetodo()
    {
        Console.WriteLine($"Saldo del debito con contanti nei confronti di {Ricevente}");
    }
}