public abstract class Lavoratore
{
    private Badge? badge;
    private string? nome, cognome;
    private DateOnly dob;
    private List<Turno> turni = new List<Turno>();

    public Badge? Badge
    {
        get => badge;
        set => badge = value;
    }
    public string? Nome
    {
        get => nome;
        set => nome = value;
    }
    public string? Cognome
    {
        get => cognome;
        set => cognome = value;
    }
    public DateOnly Dob
    {
        get => dob;
        set => dob = value;
    }
    public List<Turno> Turni
    {
        get => turni;
    }

    public void Entra()
    {
        Turno t = new Turno();
        t.Ingresso = DateTime.Now;
        turni.Add(t);
    }

    public void Esce()
    {
        turni.Last().Uscita = DateTime.Now;
    }
}