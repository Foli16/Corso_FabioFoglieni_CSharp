public class CorsoOnline : Corso
{
    private string? piattaforma;
    private string? linkAccesso;

    public string? Piattaforma
    {
        get
        {
            return piattaforma;
        }
        set => piattaforma = value;
    }
    public string? LinkAccesso
    {
        get
        {
            return linkAccesso;
        }
        set => linkAccesso = value;
    }
    public override void ErogaCorso()
    {
        Console.WriteLine($"Tipo corso: corso online, erogato dal docente {Docente?.Nome}, esperto di {Docente?.Materia}");
    }

    public override void StampaDettagli()
    {
        ErogaCorso();
        Console.WriteLine($"Corso: {Titolo}, numero ore: {DurataOre}, piattaforma: {piattaforma}, link accesso: {linkAccesso}");
    }
}