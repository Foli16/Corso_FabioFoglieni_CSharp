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
        if(turni.Count != 0 && turni.Last().Uscita == DateTime.MinValue)
        {
            Console.WriteLine("L'ultimo turno è ancora aperto. Chiudere il turno prima di aprirne un altro.");
            return;
        }
        Turno t = new Turno();
        t.Ingresso = DateTime.Now;
        turni.Add(t);
    }

    public void Esce()
    {
        if(turni.Count != 0)
        {
            if(turni.Last().Uscita > DateTime.MinValue)
            {
                Console.WriteLine("L'ultimo turno è già stato chiuso.");
                return;
            }
            turni.Last().Uscita = DateTime.Now;
        }
    }
}