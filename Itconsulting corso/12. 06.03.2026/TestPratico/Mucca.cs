public class Mucca : Animale
{
    // PROPRIETA'
    private string? coloreMacchie;

    // COSTRUTTORE
    public Mucca(string nome, int eta, string coloreMacchie) : base(nome, eta)
    {
        this.coloreMacchie = coloreMacchie;
    }

    public Mucca() {}

    // GETTER E SETTER
    public string? ColoreMacchie
    {
        get => coloreMacchie;
        set => coloreMacchie = value;
    }

    // METODI
    public override void FaiVerso()
    {
        Console.WriteLine("Le mucche fanno muuu, ma questa fa mumu");
    }

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($"- Colore macchie: {coloreMacchie}");
    }
}