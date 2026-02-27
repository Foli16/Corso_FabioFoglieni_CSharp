class Cane
{
    // Proprietà (stato)
    public string? nome;
    public int eta;

    // Metodi (comportamento)
    public void Abbaia()
    {
        Console.WriteLine($"{nome} fa bau");
    }

    public void Descriviti()
    {
        Console.WriteLine($"Sono un cane di nome {nome}, sono {eta} anni che la gente mi cerca ma non mi trova...");
    }
}