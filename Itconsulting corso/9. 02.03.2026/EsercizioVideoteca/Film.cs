class Film
{
    public string? titolo;
    public string? regista;
    public int anno;
    public string? genere;

    public override string ToString()
    {
        return $"\t- \"{titolo}\" di {regista} ({genere}, {anno})";
    }
}