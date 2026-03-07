public class Program
{
    static void Main()
    {
        Logger l1 = Logger.GetIstanza();

        l1.ScriviMessaggio("Questo è un singleton.");

        Logger l2 = Logger.GetIstanza();

        l2.ScriviMessaggio("Questo è lo stesso singleton.");

        Logger.GetIstanza().ScriviMessaggio("Ragazzo mi dispiace tu sei pazzo");

        Console.WriteLine($"Le variabili puntano allo stesso oggetto? {ReferenceEquals(l1, Logger.GetIstanza())}");
    }
}