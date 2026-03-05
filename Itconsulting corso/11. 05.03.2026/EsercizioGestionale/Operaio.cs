public class Operaio : Lavoratore
{
    private Officina officina;
    private string? mansione;

    public Officina Officina
    {
        get => officina;
        set => officina = value;
    }
}