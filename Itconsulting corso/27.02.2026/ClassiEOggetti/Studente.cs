class Studente
{
    public string? name;
    public int matricola;
    public double mediaVoti;

    public void Info()
    {
        Console.WriteLine($"Nome studente: {name}\nMatricola: {matricola}\nMedia voti: {mediaVoti}");
    }
}