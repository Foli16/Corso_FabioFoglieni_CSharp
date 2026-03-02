class Macchina
{
    public string? motore;
    public float velocitaMax;
    public int sospensioniMax;
    public int nrModifiche;

    public Macchina()
    {
        motore = "Motore endotermico";
        velocitaMax = 150;
        sospensioniMax = 4;
        nrModifiche = 0;
    }

    public override string ToString()
    {
        return $"\t- Tipo motore: {motore}\n\t- Velocità massima: {velocitaMax}\n\t- Valore sospensioni: {sospensioniMax}\n\t- Numero modifiche: {nrModifiche}";
    }
}