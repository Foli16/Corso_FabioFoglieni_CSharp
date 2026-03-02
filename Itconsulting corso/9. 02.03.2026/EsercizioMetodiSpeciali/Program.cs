using System;

class Program
{
    static void Main()
    {
        Libro l1 = new Libro() {titolo = "Guerra e pace", autore = "Lev Tolstoj", annoPubblicazione = 1867};
        Libro l2 = new Libro() {titolo = "Guerra e pace", autore = "Lev Tolstoj", annoPubblicazione = 1867};

        // To String
        Console.WriteLine(l1);
        Console.WriteLine(l2);

        // Equals
        Console.WriteLine($"\nl1 è uguale a l2? {l1.Equals(l2)}");

        // GetHashCode
        Console.WriteLine($"\nHashCode di l1: {l1.GetHashCode()}");
        Console.WriteLine($"HashCode di l2: {l2.GetHashCode()}");
        Console.WriteLine($"\nL'hashcode di l1 è uguale a quello di l2? {l1.GetHashCode() == l2.GetHashCode()}");

        // GetType
        Console.WriteLine($"\nTipo di l1: {l1.GetType()}");
        Console.WriteLine($"Tipo di l2: {l2.GetType()}");

        // ReferenceEquals
        Console.WriteLine($"\nl1 e l2 si riferiscono allo stesso oggetto? {ReferenceEquals(l1, l2)}");
        Console.WriteLine($"\nl1.titolo e l2.titolo hanno la stessa reference? {ReferenceEquals(l1.titolo, l2.titolo)}");

        // MemberwiseClone;
        Libro l3 = l1.Copia();
    }
}