using System;

class Program
{
    static void Main(string[] args)
    {
        // ARRAY
        int[] voti = new int[5];

        for(int i = 0; i< voti.Length; i++)
        {
            Console.Write($"Inserisci il voto {i+1}: ");
            voti[i] = int.Parse(Console.ReadLine()!);
        }

        int somma = 0;
        for (int i = 0; i < voti.Length; i++)
        {
            somma += voti[i];
        }

        float media = (float)somma/voti.Length;
        Console.WriteLine($"La media dei voti è: {media}");


        // FOR EACH
        string parola = "CSharp";

        Console.WriteLine("Caratteri della stringa:");
        foreach (char carattere in parola)
        {
            Console.WriteLine(carattere);
        }

        int[] numberArray = [5,3,2,7,8,3];

        Console.WriteLine("Numeri nell'array:");
        foreach (int numero in numberArray)
            System.Console.WriteLine(numero);

        // ESERCIZIO FOR EACH
        do
        {
            System.Console.WriteLine("Vuoi un array di stringhe o di interi? (s/i)");
            string sCase = Console.ReadLine()!;
            System.Console.WriteLine("Quale dimensione deve avere? Dammi un intero");
            switch(sCase)
            {
                case "s":
                    string[] sArray = new string[int.Parse(Console.ReadLine()!)];

                    for(int i = 0; i < sArray.Length; i++)
                    {
                        System.Console.Write($"Inserisci la stringa numero {i+1}: ");
                        sArray[i] = Console.ReadLine()!;
                    }
                    System.Console.WriteLine("Stampo stringhe:");
                    foreach(string s in sArray)
                        System.Console.WriteLine(s);
                    break;
                case "i":
                    int[] nArray = new int[int.Parse(Console.ReadLine()!)];

                    for(int i = 0; i < nArray.Length; i++)
                    {
                        System.Console.Write($"Inserisci il numero alla posizione {i+1}: ");
                        nArray[i] = int.Parse(Console.ReadLine()!);
                    }
                    System.Console.WriteLine("Stampo numeri:");
                    foreach(int n in nArray)
                        System.Console.WriteLine(n);
                    break;
                default:
                    System.Console.WriteLine("Comando non valido.");
                    break;
            }
            System.Console.WriteLine("Vuoi ripetere? (y/n)");
        } while(Console.ReadLine()!.ToLower() == "y"); 


        // ESERCIZIO 1
        System.Console.WriteLine("Inserisci una frase");
        int counter = 0;
        foreach (char c in Console.ReadLine()!)
        {
            if(char.IsDigit(c))
                counter++;
        }
        System.Console.WriteLine($"Ci sono {counter} cifre in questa frase");

        // ESERCIZIO 2
        System.Console.WriteLine("Inserisci una frase");
        string nuova = "";
        foreach(char c in Console.ReadLine()!)
        {
            if(!char.IsWhiteSpace(c))
                nuova += c;
        }
        System.Console.WriteLine("La nuova frase è: " + nuova);

        // ESERCIZIO 3
        string vowels = "aeiou";
        int vCounter = 0;
        System.Console.WriteLine("Inserisci una stringa:");

        foreach(char c in Console.ReadLine()!)
        {
            if(vowels.Contains(char.ToLower(c)))
                vCounter++;
        }
        System.Console.WriteLine($"Vocali nella frase: {vCounter}");

        // ESERCIZIO 4
        System.Console.Write("Inserisci una password: ");
        string password = Console.ReadLine()!;

        bool minimumLenght = password.Length >= 8;
        bool blankCheck = password.Trim() == password;
        bool upperChar = false;
        bool cypherChar = false;

        foreach(char c in password)
        {
            if(char.IsUpper(c))
                upperChar = true;
            if(char.IsDigit(c))
                cypherChar = true;
        }

        if(minimumLenght && blankCheck && upperChar && cypherChar)
            System.Console.WriteLine("Password accettabile");
        else
            System.Console.WriteLine("Password non valida");

        // ESERCIZIO 5
        System.Console.WriteLine("Inserisci una stringa:");
        string str = Console.ReadLine()!;

        int wordCounter = 0, alphabeticCharCounter = 0, whiteSpaceCounter = 0, punctuationCounter = 0;
        if(str.Trim().Length>0)
            wordCounter = str.Trim().Split(' ').Length;
        foreach(char c in str)
        {
            if(char.IsLetter(c))
                alphabeticCharCounter++;
            if(char.IsWhiteSpace(c))
                whiteSpaceCounter++;
            if(char.IsPunctuation(c))
                punctuationCounter++;
        }
            
        System.Console.WriteLine($"Numero di parole: {wordCounter}");
        System.Console.WriteLine($"Numero di caratteri alfabetici: {alphabeticCharCounter}");
        System.Console.WriteLine($"Numero di spazi: {whiteSpaceCounter}");
        System.Console.WriteLine($"Numero di segni di punteggiatura: {punctuationCounter}");
    }
}