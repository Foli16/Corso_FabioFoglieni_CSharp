class Corso
{
    public string? nomeCorso;
    public int durataOre;
    public string? docente;
    public List<string> studenti = new List<string>();

    public void AggiungiStudente(string nomeStudente)
    {
        studenti.Add(nomeStudente);
    }

    public override string ToString()
    {
        return $"\t- Nome: {nomeCorso}\n\t- Durata: {durataOre}\n\t- Docente: {docente}\n";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine("Metodo speciale classe padre");
    }
}