using System;

//commento di una riga

/*
Commento
di
più
righe
*/


class Program
{
    const int COSTANTE = 4;
    public static readonly string soloLettura = "sono letto";
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int counter;
        counter = 100;
        var nome = "var";

        Console.WriteLine(counter + " " + nome);

        string s = "stringa poco politicamente corretta";

        Console.WriteLine(s);

        int numero = 10;                        //numero intero
        float decimaleFloat = 3.14f;            //numero a virgola mobile
        double decimaleDouble = 3.14d;          //numero a virgola mobile
        char lettera = 'a';                     //singolo carattere
        bool condizione = true;                 //bit 0 (false) o 1 (true)
        string saluto = "Ciao a tutti rugoni!"; //molteplici char

        Console.WriteLine("Numero: "+numero);
        Console.WriteLine("Decimale: "+decimaleDouble + " oppure "+decimaleFloat);
        Console.WriteLine("Lettera: "+lettera);
        Console.WriteLine("Condizione: "+condizione);
        Console.WriteLine("Saluto: "+saluto);

        
        Console.WriteLine("Ecco la costante: "+COSTANTE);
        Console.WriteLine("Ecco la readonly: "+soloLettura);
        
        //Casting implicito (safe, nessuna perdita di dati)
        int intero = 42;                        
        float numeroLunghissimo = intero+0.6f;       //widening - da più piccolo a più grande

        //Casting esplicito (potenziale perdita / eccezione)
        float pi = 3.14f;
        int piTroncato = (int)pi;               //narrowing - dal più grande al più piccolo

        Console.WriteLine("Cast implicito: " + numeroLunghissimo);
        Console.WriteLine("Cast esplicito: " + piTroncato);

        // Console.Write("Come ti chiami? ");
        // string nome2 = Console.ReadLine();
        // Console.WriteLine("Ti chiami" + $" {nome2}");
        // Console.Write("Dammi un numero: ");
        // int numero1 = int.Parse(Console.ReadLine());
        // Console.Write("Dammi un altro numero: ");
        // int numero2 = int.Parse(Console.ReadLine());
        // Console.WriteLine($"Somma {numero1+numero2}!");

        int a = 10, b= 5;
        Console.WriteLine("Operatori aritmetici:");
        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"Addizione: a + b = {a+b}");
        Console.WriteLine($"Sottrazione: a - b = {a-b}");
        Console.WriteLine($"Moltiplicazione: a * b = {a*b}");
        Console.WriteLine($"Divisione: a / b = {a/b}");
        Console.WriteLine($"Modulo (resto): a % b = {a%b}");
        Console.WriteLine("Operatori assegnamento");
        Console.WriteLine($"Incremento di 1: a++ = {a++}");
        Console.WriteLine($"Ora a = {a}");
        Console.WriteLine($"Decremento di 1: b-- = {b--}");
        Console.WriteLine($"Ora a = {b}");
        Console.WriteLine("Operatori logici:");
        Console.WriteLine($"AND: {a<b && a>=10}");
        Console.WriteLine($"OR: {a>b || a>=10}");
        Console.WriteLine($"NOT: {!(a<b)}");
    }
}