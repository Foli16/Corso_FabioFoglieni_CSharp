public class CorsoInPresenza : Corso
{
    private string? aula;
    private int numeroPosti;

    public string? Aula
    {
        get
        {
            return aula;
        }
        set => aula = value;
    }
    public int NumeroPosti
    {
        get
        {
            return numeroPosti;
        }
        set
        {
            if(value > 0)
                numeroPosti = value;
            else
                Console.WriteLine("Deve esserci almeno 1 posto.");
        }
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Tipo corso: Corso in presenza, erogato dal docente {Docente?.Nome}, esperto di {Docente?.Materia}");
    }

    public override void StampaDettagli()
    {
        ErogaCorso();
        Console.WriteLine($"Corso: {Titolo}, numero ore: {DurataOreGet}, aula: {aula}, numero posti: {numeroPosti}");
    }
}