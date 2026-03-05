using System.ComponentModel.DataAnnotations;

public class PagamentoPayPal : Pagamento, IPagamento
{
    private string? emailUtente;

    public PagamentoPayPal(string ricevente, string emailUtente) : base(ricevente)
    {
        EmailUtente = emailUtente;
    }

    public string? EmailUtente
    {
        set
        {
            if(value!.Contains('@'))
            {
                emailUtente = value;
            }
            else
                throw new ValidationException("Email non valida. Deve contenere una \'@\'.");
        }
    }

    public void EseguiPagamento(double importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro tramite PayPal da: {emailUtente}");
    }

    public void MostraMetodo()
    {
        Console.WriteLine($"Saldo del debito con PayPal nei confronti di {Ricevente}");
    }
}