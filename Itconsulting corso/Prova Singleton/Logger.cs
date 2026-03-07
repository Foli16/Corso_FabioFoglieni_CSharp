public class Logger
{
    private static Logger? unicaIstanza;

    private Logger() {}

    public static Logger GetIstanza()
    {
        if(unicaIstanza == null)
            unicaIstanza = new Logger();
        return unicaIstanza;
    }

    public void ScriviMessaggio(string messaggio)
    {
        Console.WriteLine($"Log: {DateTime.Now}, messaggio: {messaggio}");
    }
}