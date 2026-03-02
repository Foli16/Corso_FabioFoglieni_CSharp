class VoloAereo
{
    const int maxPosti = 150;
    
    private int postiOccupati;
    private int codiceVolo;
    private int postiLiberi = maxPosti;

    public VoloAereo(int codiceVolo)
    {
        this.codiceVolo = codiceVolo;
    }

    public void EffettuaPrenotazione(int numeroPosti)
    {
        if(postiLiberi >= numeroPosti && postiOccupati+numeroPosti <= maxPosti)
        {
            postiOccupati += numeroPosti;
            postiLiberi -= numeroPosti;
            Console.WriteLine("Prenotazione effettuata.");
        }
        else
            Console.WriteLine("Non è possibile effettuare questa prenotazione.");
    }

    public void AnnullaPrenotazione(int numeroPosti)
    {
        if(numeroPosti <= postiOccupati && postiOccupati-numeroPosti >= 0)
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