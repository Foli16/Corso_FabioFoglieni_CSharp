public class Program
{
    static void Main()
    {
        List<IPagamento> pagamenti = new List<IPagamento>();

        IPagamento p1 = new PagamentoCarta("Peppino", "AUTODROMO DI MONZA");
        IPagamento p2 = new PagamentoContanti("Germano");
        IPagamento p3 = new PagamentoPayPal("Giacomino", "porkypig@mail.com");

        pagamenti.Add(p1);
        pagamenti.Add(p2);
        pagamenti.Add(p3);

        foreach(IPagamento p in pagamenti)
        {
            p.MostraMetodo();
            Console.Write("Inserisci importo: ");
            p.EseguiPagamento(int.Parse(Console.ReadLine()!));
            Console.WriteLine();
        }
    }
}
