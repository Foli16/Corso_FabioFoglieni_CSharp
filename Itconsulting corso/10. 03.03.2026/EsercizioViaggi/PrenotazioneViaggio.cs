class PrenotazioneViaggio : VoloAereo
{
    private const int maxPostiPrenotazione = 20;
    private string? destinazione;

    public override void PrenotaPosti(int numero)
    {
        if(numero <= 0 || numero > maxPostiPrenotazione)
        {
            Console.WriteLine("Numero posti non valido.");
            return;
        }
        if(postiOccupati+numero <= maxPosti)
        {
            postiOccupati += numero;
            postiLiberi -= numero;
            Console.WriteLine("Prenotazione effettuata.");
        }
        else
            Console.WriteLine("Non è possibile effettuare questa prenotazione.");
    }

    public override void AnnullaPrenotazione(int numero)
    {
        if(numero <= 0)
        {
            Console.WriteLine("Numero posti non valido.");
            return;
        }
        if(postiOccupati-numero >= 0)
        {
            postiOccupati -= numero;
            postiLiberi += numero;
            Console.WriteLine("Annullamento effettuato.");
        }
        else
            Console.WriteLine("Non è possibile effettuare questo annullamento.");
    }

    public int PostiPrenotati
    {
        get
        {
            return postiOccupati;
        }
    }

    public string Destinazione
    {
        get
        {
            return destinazione;
        }
        set
        {
            destinazione = value;
        }
    }

    public int PostiDisponibili
    {
        get
        {
            return postiLiberi;
        }
    }
}