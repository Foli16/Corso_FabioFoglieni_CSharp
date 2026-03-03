class VoloAereo
{
    protected const int maxPosti = 150;
    
    protected int postiOccupati;
    private int codiceVolo;
    protected int postiLiberi = maxPosti;

    public virtual void PrenotaPosti(int numeroPosti)
    {
        if(postiOccupati+numeroPosti <= maxPosti)
        {
            postiOccupati += numeroPosti;
            postiLiberi -= numeroPosti;
            Console.WriteLine("Prenotazione effettuata.");
        }
        else
            Console.WriteLine("Non è possibile effettuare questa prenotazione.");
    }

    public virtual void AnnullaPrenotazione(int numeroPosti)
    {
        if(postiOccupati-numeroPosti >= 0)
        {
            postiOccupati -= numeroPosti;
            postiLiberi += numeroPosti;
            Console.WriteLine("Annullamento effettuato.");
        }
        else
            Console.WriteLine("Non è possibile effettuare questo annullamento.");
    }

    public void VisualizzaStato()
    {
        Console.WriteLine($"Codice volo: {codiceVolo}, posti occupati: {postiOccupati}, posti liberi: {postiLiberi}");
    }

    public int GetCodiceVolo()
    {
        return codiceVolo;
    }

    public void SetCodiceVolo(int codiceVolo)
    {
        this.codiceVolo = codiceVolo;
    }
    public int GetPostiOccupati()
    {
        return postiOccupati;
    }

    public void SetPostiOccupati(int postiOccupati)
    {
        this.postiOccupati = postiOccupati;
    }
}