public class Stampante(string modello) : DispositivoElettronico(modello)
{
    public override void Accendi()
    {
        Console.WriteLine("La stampante si accende...");
    }
    public override void Spegni()
    {
        Console.WriteLine("La stampante va in standby.");
    }
}