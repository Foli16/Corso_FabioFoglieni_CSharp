public abstract class DispositivoElettronico
{
    private string? modello;

    public DispositivoElettronico(string modello)
    {
        this.modello = modello;
    }

    public abstract void Accendi();
    public abstract void Spegni();
    public virtual void MostraInfo()
    {
        Console.WriteLine($"Modello dispositivo: {modello}");
    }
}