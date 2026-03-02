class Cane : Animale
{
    public void Scodinzola()
    {
        Console.WriteLine("Il cane scodinzola.");
    }

    public override void FaiVerso()
    {
        // base.FaiVerso();
        Console.WriteLine("Il cane abbaia.");
    }

    // OSCURA IL METODO CONTENUTO NEL PADRE, COME SE NON ESISTESSE NEL PADRE
    // SETTA UN NUOVO PUNTO DI PARTENZA DA CUI EREDITANO IL METODO I FIGLI
    public new void Cammina()
    {
        Console.WriteLine("Il cane cammina.");
    }

    public void ImpostaEta(int eta)
    {
        this.eta = eta;
    }
}