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
    public string? DurataOreSet
    {
        
        set
        {
            if (int.TryParse(value, out int valore) && valore >= 0)
            {
                durataOre = valore;
                return;
            }
            do
            {
                Console.Write("Valore non compatibile. Inserire un numero positivo: ");
            } while (!int.TryParse(Console.ReadLine(), out valore) || valore < 0);

            durataOre = valore;
        }
    }

    public int DurataOreGet
    {
        get 
        {
            return durataOre;
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