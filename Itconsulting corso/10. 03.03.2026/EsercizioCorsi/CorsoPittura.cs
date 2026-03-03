class CorsoPittura : Corso
{
    public string? tecnica;

    public override string ToString()
    {
        return $"{base.ToString()}\t- Tecnica: {tecnica}\n";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su una tela con tecnica: {tecnica}");
    }
}