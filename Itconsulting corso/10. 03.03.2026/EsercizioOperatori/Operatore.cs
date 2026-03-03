class Operatore
{
    private string? nome, turno;

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

    public string? Turno
    {
        get
        {
            return turno;
        }
        set
        {
            if(value?.ToLower() == "giorno" || value?.ToLower() == "notte")
                turno = value.ToLower();
        }
    }
    
    public virtual void EseguiCompito()
    {
        Console.WriteLine("Operatore generico in servizio.");
    }

    public override string ToString()
    {
        return $"\t- Nome: {nome}, tipo operatore: {GetType()}, turno: {turno}";
    }
}