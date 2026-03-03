class CorsoMusica : Corso
{
    public string? strumento;

    public override string ToString()
    {
        return $"{base.ToString()}\t- Strumento: {strumento}\n";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {strumento}");
    }
}