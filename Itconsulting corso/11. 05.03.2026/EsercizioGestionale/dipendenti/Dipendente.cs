public abstract class Dipendente
{
    private Badge? badge;
    private string? nome, cognome;
    private DateOnly dob;
    private List<Turno> turni = new List<Turno>();

    public Dipendente(Badge badge, string nome, string cognome, DateOnly dob)
    {
        this.badge = badge;
        this.nome = nome;
        this.cognome = cognome;
        this.dob = dob;
    }

    public Badge? Badge
    {
        get => badge;
    }
    public string? Nome
    {
        get => nome;
    }
    public string? Cognome
    {
        get => cognome;
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