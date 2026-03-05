public abstract class Veicolo
{
    public abstract void Avvia();
}

public class Auto : Veicolo
{
    public override void Avvia()
    {
        Console.WriteLine("L'auto si accende.");;
    }
}

public interface IVeicoloElettrico
{
    void Ricarica();
}

public class ScooterElettrico : IVeicoloElettrico
{
    public void Ricarica()
    {
        Console.WriteLine("Scooter in carica.");
    }
}