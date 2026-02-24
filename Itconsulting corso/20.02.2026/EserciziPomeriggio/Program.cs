using System;

class Program
{
    static void Main()
    {
        // ESERCIZIO 1
        int numero = 4;
        Console.WriteLine($"Numero prima: {numero}");
        Raddoppia(ref numero);
        Console.WriteLine($"Numero dopo: {numero}");

        // ESERCIZIO 2
        int giorno = 28, mese = 10, anno = 2026;
        Console.WriteLine($"Data di partenza: {giorno}/{mese}/{anno}");
        Console.WriteLine("Quanti giorni vuoi aggiungere?");
        int aggiunta = int.Parse(Console.ReadLine()!);
        AggiustaData(ref giorno, ref mese, ref anno, aggiunta);
        Console.WriteLine($"Data aggiornata: {giorno}/{mese}/{anno}");

        // ESERCIZIO 3
        int quoziente;
        int resto;
        int numero1 = 20, numero2 = 3;
        Dividi(numero1, numero2, out quoziente, out resto);
        Console.WriteLine($"Risultato divisione tra {numero1} e {numero2}: {quoziente} con resto di {resto}");

        // ESERCIZIO 4
        string frase = "Inizializzo la variabile";
        int vocali, consonanti, spazi;
        AnalizzaParola(frase, out vocali, out consonanti, out spazi);
        Console.WriteLine($"Vocali: {vocali}, consonanti: {consonanti}, spazi: {spazi}");

        // ESERCIZIO 5
        int punteggioCorrente;
        int bonus;
        int punteggioTotale = 0;
        int punteggioMedio = 0;

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Dammi il punteggio corrente:");
            punteggioCorrente = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Dammi il bonus se presente o inserisci 0:");
            bonus = int.Parse(Console.ReadLine()!);
            AggiornaPunteggio(ref punteggioCorrente, bonus, ref punteggioTotale, out punteggioMedio);
        }
        Console.WriteLine($"Punteggio totale: {punteggioTotale}, punteggio medio: {punteggioMedio}");

        // ESERCIZIO 6
        Console.WriteLine("Dammi il primo voto:");
        int voto1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Bonus primo voto?");
        int bonus1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Dammi il secondo voto:");
        int voto2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Bonus secondo voto?");
        int bonus2 = int.Parse(Console.ReadLine()!);

        bool promosso = ElaboraStudente(ref voto1, ref voto2, bonus1, bonus2, out double media);

        Console.WriteLine($"Lo studente è passato? {promosso} | Media: {media}, voto 1: {voto1}, voto 2: {voto2}");
    }

    private static void Raddoppia(ref int n)
    {
        n *= 2;
    }
    
    private static void AggiustaData(ref int giorno, ref int mese, ref int anno, int aggiunta)
    {
        while(aggiunta>=30)
        {
            mese++;
            if(mese>12)
            {
                anno++;
                mese = 1;
            }
            aggiunta -= 30;
        }

        if(giorno+aggiunta>30)
        {
            mese++;
            giorno += aggiunta-30;
        }
        else
            giorno += aggiunta;
    }

    private static void Dividi(int n1, int n2, out int quoziente, out int resto)
    {
        quoziente = n1/n2;
        resto = n1%n2;
    }

    private static void AnalizzaParola(string frase, out int vocali, out int consonanti, out int spazi)
    {
        vocali = 0;
        consonanti = 0;
        spazi = 0;
        string controlloVocali = "aeiou";
        foreach(char c in frase)
        {
            if(controlloVocali.Contains(char.ToLower(c)))
                vocali++;
            if(char.IsLetter(c) && !controlloVocali.Contains(char.ToLower(c)))
                consonanti++;
            if(char.IsWhiteSpace(c))
                spazi++;
        }
    }

    private static void AggiornaPunteggio(ref int punteggioCorrente, int bonus, ref int punteggioTotale, out int punteggioMedio)
    {
        punteggioTotale += punteggioCorrente + bonus;
        punteggioMedio = punteggioTotale/3;
    }

    private static bool ElaboraStudente(ref int voto1, ref int voto2, int bonus1, int bonus2, out double media)
    {
        voto1 = voto1+bonus1>10 ? 10 : voto1+bonus1;
        voto2 = voto2+bonus2>10 ? 10 : voto2+bonus2;

        media = (voto1+voto2) / 2.0;

        return media >= 6;
    }
}
