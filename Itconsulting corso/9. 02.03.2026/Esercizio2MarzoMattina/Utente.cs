class Utente
{
    public string? nome;
    public int credito;

    public Utente(string nome)
    {
        this.nome = nome;
        this.credito = 5;
    }

    public override string ToString()
    {
        return $"\t- Nome: {nome}\n\t- Credito residuo: {credito}";
    }
}