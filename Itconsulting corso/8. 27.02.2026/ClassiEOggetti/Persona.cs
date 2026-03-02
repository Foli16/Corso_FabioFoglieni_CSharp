class Persona
{
    public string nome = string.Empty;
    public string cognome = string.Empty;
    public int eta;
    public int annoNascita;

    public Persona(string nome, int eta)
    {
        this.nome = nome;
        cognome = "";
        this.eta = eta;
    }

    public Persona(string nome, string cognome, int annoNascita)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.annoNascita = annoNascita;
    }

    public void Presentazione()
    {
        Console.WriteLine($"{nome} {cognome} è nato nel {annoNascita}");
    }

    public override string ToString()
    {
        return $"Nome: {nome}, cognome: {cognome}, età: {eta}, anno di nascita: {annoNascita}";
    }
}