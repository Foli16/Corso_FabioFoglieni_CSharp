public class Pecora : Animale
{
    // PROPRIETA'
    private bool tosata;

    // COSTRUTTORE
    public Pecora(string nome, int eta, bool tosata) : base(nome, eta)
    {
        this.tosata = tosata;
    }
    public Pecora() {}

     // GETTER E SETTER
    public bool Tosata
    {
        get => tosata;
        set => tosata = value;
    }

    // METODI
    public override void FaiVerso()
    {
        Console.WriteLine("La pecora bela, poi sviene.");
    }

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($"- È stata tosata? {tosata}");
    }
}