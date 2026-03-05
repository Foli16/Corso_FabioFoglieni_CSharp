public class Impiegato : Dipendente
{
    private Ufficio ufficio;

    public Impiegato(Badge badge, string nome, string cognome, DateOnly dob, Ufficio ufficio) : base(badge, nome, cognome, dob)
    {
        this.ufficio = ufficio;
    }
}