using System.ComponentModel.DataAnnotations;

public abstract class Corso
{
    private string? titolo;
    private int durataOre;

    private Docente? docente;

    public string? Titolo
    {
        get 
        {
            return titolo;
        }
        set => titolo = value;
    }
    public int DurataOre
    {
        get 
        {
            return durataOre;
        }
        set
        {
            if(value >= 0)
                durataOre = value;
            else
                Console.WriteLine("La durata deve avere un valore positivo.");
        }
    }

    public Docente? Docente
    {
        get
        {
            return docente;
        }
        set
        {
            docente = value;
        }
    }

    public abstract void ErogaCorso();
    public abstract void StampaDettagli();
}