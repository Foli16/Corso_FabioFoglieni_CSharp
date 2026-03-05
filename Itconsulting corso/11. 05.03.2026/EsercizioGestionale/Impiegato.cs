public class Impiegato : Lavoratore
{
    private Ufficio ufficio;
   // private string? mansione;

    public Ufficio Ufficio
    {
        get => ufficio;
        set => ufficio = value;
    }
}