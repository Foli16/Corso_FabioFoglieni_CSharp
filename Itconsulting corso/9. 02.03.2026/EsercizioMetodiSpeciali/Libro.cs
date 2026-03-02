class Libro
{
    public string? titolo;
    public string? autore;
    public int annoPubblicazione;

    public override string ToString()
    {
        return $"{titolo} di {autore} ({annoPubblicazione})";
    }

    public override bool Equals(object? obj)
    {
        if(obj is Libro l)
            return titolo == l.titolo && autore == l.autore;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(titolo, autore);
    }

    public Libro Copia()
    {
        return (Libro)this.MemberwiseClone();
    }
}