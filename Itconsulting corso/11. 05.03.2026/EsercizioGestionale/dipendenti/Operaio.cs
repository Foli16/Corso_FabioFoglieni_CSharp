public class Operaio : Dipendente
{
    private Officina officina;
    private string? mansione;

    public Operaio(Badge badge, string nome, string cognome, DateOnly dob, Officina officina, string mansione) : base(badge, nome, cognome, dob)
    {
        this.officina = officina;
        this.mansione = mansione;
    }
}