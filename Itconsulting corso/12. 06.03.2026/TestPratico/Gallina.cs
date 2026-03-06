public class Gallina : Animale
{
    // PROPRIETA'
    private int uovaDeposte;

    // COSTRUTTORE
    public Gallina(string nome, int eta, int uovaDeposte) : base(nome, eta)
    {
        this.uovaDeposte = uovaDeposte;
    }
    public Gallina() {}

     // GETTER E SETTER
    public int UovaDeposte
    {
        get => uovaDeposte;
        set
        {
            if(value > 0)
                uovaDeposte = value;
            else
                Console.WriteLine("Non va bene.");
        }
    }

    // METODI
    public override void FaiVerso()
    {
        Console.WriteLine("La gallina fa coccodé e ti alzi dal letto di \"buon umore\"");
    }

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($"- Uova deposte ultima volta: {uovaDeposte}");
    }
}