public abstract class Animale
{
    // PROPRIETA'
    private string? nome;
    private int eta;

    // COSTRUTTORE
    public Animale(string nome, int eta)
    {
        this.nome = nome;
        this.eta = eta;
    }
    public Animale() {}

    // GETTER E SETTER
    public string? Nome
    {
        get => nome;
        set => nome = value;
    }

    public int Eta
    {
        get => eta;
        set
        {
            if(value >= 0)
                eta = value;
            else
                Console.WriteLine("Non va bene.");
        }
    }

    // METODI
    public virtual void StampaInfo()
    {
        Console.WriteLine($"- Nome: {nome}");
        Console.WriteLine($"- Età: {eta}");
    }

    public abstract void FaiVerso();
}