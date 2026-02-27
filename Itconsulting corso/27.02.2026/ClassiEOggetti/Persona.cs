class Persona
{
    public string nome;
    public string cognome;
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
}