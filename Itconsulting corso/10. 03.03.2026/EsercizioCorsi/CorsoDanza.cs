class CorsoDanza : Corso
{
    public string? stile;

    public override string ToString()
    {
        return $"{base.ToString()}\t- Stile: {stile}\n";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografia nello stile: {stile}");
    }
}