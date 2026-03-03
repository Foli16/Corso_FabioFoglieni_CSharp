class Soldato
{
    private string? nome;
    private string? grado;
    private int anniServizio;

    public virtual void Descrizione()
    {
        Console.Write($"\t- {nome}, grado {grado}, anni di servizio {anniServizio}");
    }

    public string? Nome
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }
    }
    public string? Grado
    {
        get
        {
            return grado;
        }
        set
        {
            grado = value;
        }
    }
    public int AnniServizio
    {
        get
        {
            return anniServizio;
        }
        set
        {
            if(value >= 0)
                anniServizio = value;
        }
    }
}