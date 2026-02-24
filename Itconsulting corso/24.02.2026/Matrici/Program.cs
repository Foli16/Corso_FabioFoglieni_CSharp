using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        // -- ESERCIZI SU RANDOM --
        // ESERCIZIO 1
        int numeroRandom;
        int input;
        do
        {
            numeroRandom = rnd.Next(1,11);
            Console.WriteLine("Indovina un numero tra 1 e 10");
            input = int.Parse(Console.ReadLine()!);
            if(numeroRandom == input)
                Console.WriteLine("Indovinato!");
            else
            {
                Console.WriteLine($"Che fallito! Il numero era {numeroRandom}");
            }
        }while(input != numeroRandom); 

        // ESERCIZIO 2
        int dadi = rnd.Next(1,13);
        Console.WriteLine($"Il lancio di dadi ha restituito un {dadi}");

        // ESERCIZIO 3
        int minTemp = 5;
        int maxTemp = 25;
        Console.WriteLine("Dammi un numero di giorni che vuoi simulare");
        int giorni = int.Parse(Console.ReadLine()!);
        int[] temperature = new int[giorni];
        int minima = maxTemp-1;
        int massima = 0;
        int somma = 0;
        for (int i = 0; i < temperature.Length; i++)
        {
            temperature[i] = rnd.Next(minTemp, maxTemp);
            Console.WriteLine($"Temperatura giorno {i+1}: {temperature[i]}");
            somma += temperature[i];
            if(temperature[i] > massima)
                massima = temperature[i];
            if(temperature[i] < minima)
                minima = temperature[i];
        }
        int media = somma / temperature.Length;
        Console.WriteLine($"Temperatura minima: {minima}, massima: {massima}, media: {media}");

        // -- ESERCIZI SU MATRICI --
        // ESERCIZIO 1
        Console.WriteLine("Dammi la dimensione della matrice (righe e colonne)");
        int righe = int.Parse(Console.ReadLine()!);
        int colonne = int.Parse(Console.ReadLine()!);

        int[,] matrice2 = new int[righe, colonne];
        int somma2 = 0;
        for (int i = 0; i < matrice2.GetLength(0); i++)
        {
            for (int j = 0; j < matrice2.GetLength(1); j++)
            {
                matrice2[i,j] = rnd.Next(1,31);
                Console.WriteLine($"Elemento alla posizione [{i}][{j}]: {matrice2[i,j]}");
                somma2 += matrice2[i,j];
            }
        }
        Console.WriteLine($"\nSomma tutti gli elementi: {somma2}\n");

        int[] arrayR = new int[righe];
        int[] arrayC = new int[colonne];
        for (int i = 0; i < matrice2.GetLength(0); i++)
        {
            for (int j = 0; j < matrice2.GetLength(1); j++)
            {
                arrayR[i] += matrice2[i,j];
            }
            Console.WriteLine($"La somma della riga {i+1} è {arrayR[i]}");
        }
        for (int i = 0; i < matrice2.GetLength(1); i++)
        {
            for (int j = 0; j < matrice2.GetLength(0); j++)
            {
                arrayC[i] += matrice2[j,i];
            }
            Console.WriteLine($"La somma della colonna {i+1} è {arrayC[i]}");
        }

        // ESERCIZIO 2
        int[,] matrice4x4_1 = new int[4,4];
        int[,] matrice4x4_2 = new int[4,4];

        for (int i = 0; i < matrice4x4_1.GetLength(0); i++)
            for (int j = 0; j < matrice4x4_1.GetLength(1); j++)
            {
                matrice4x4_1[i,j] = rnd.Next(1,51);
                matrice4x4_2[i,j] = rnd.Next(1,51);
            }

        int[] arrayR_1 = new int[matrice4x4_1.GetLength(0)];
        int[] arrayR_2 = new int[matrice4x4_2.GetLength(0)];
        for (int i = 0; i < matrice4x4_1.GetLength(0); i++)
        {
            for (int j = 0; j < matrice4x4_1.GetLength(1); j++)
            {
                Console.Write($"|{matrice4x4_1[i,j]}|");
                arrayR_1[i] += matrice4x4_1[i,j];
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < matrice4x4_2.GetLength(0); i++)
        {
            for (int j = 0; j < matrice4x4_2.GetLength(1); j++)
            {
                Console.Write($"|{matrice4x4_2[i,j]}|");
                arrayR_2[i] += matrice4x4_2[i,j];
            }
            Console.WriteLine();
        }

        int punti_1 = 0;
        int punti_2 = 0;
        for (int i = 0; i < arrayR_1.Length; i++)
        {
            if(arrayR_1[i] > arrayR_2[i])
                punti_1++;
            else
                punti_2++;
        }
        Console.WriteLine($"\nPunti righe prima matrice: {punti_1}, Punti righe seconda matrice: {punti_2}");
        if(punti_1 > punti_2)
            Console.WriteLine("Vince la prima matrice!");
        else if(punti_1 < punti_2)
            Console.WriteLine("Vince la seconda matrice!");
        else
            Console.WriteLine("Pareggio!");
        

        // ESERCIZIO 3
        int[,] matriceQuadrata = new int[5,5];
        int sommaDiagonaleP = 0;
        int sommaDiagonaleS = 0;

        for (int i = 0; i < matriceQuadrata.GetLength(0); i++)
        {
            for (int j = 0; j < matriceQuadrata.GetLength(1); j++)
            {
                matriceQuadrata[i,j] = rnd.Next(1,21);
                Console.Write($"|{matriceQuadrata[i,j]}|");
                if(i == j)
                    sommaDiagonaleP += matriceQuadrata[i,j];
                if(j == matriceQuadrata.GetLength(1)-1-i)
                    sommaDiagonaleS += matriceQuadrata[i,j];
            }
            Console.WriteLine();
        }

        // FIGATA
        //for(int i = 0, j = matriceQuadrata.GetLength(0)-1; i < matriceQuadrata.GetLength(0); i++, j--)

        Console.WriteLine($"\nSomma diagonale principale: {sommaDiagonaleP}, Somma diagonale secondaria: {sommaDiagonaleS}");

        if(sommaDiagonaleP > sommaDiagonaleS)
            Console.WriteLine("La diagonale principale è maggiore!");
        else if(sommaDiagonaleP < sommaDiagonaleS)
            Console.WriteLine("La diagonale secondaria è maggiore!");
        else
            Console.WriteLine("Le diagonali hanno la stessa somma!");

        // -- ESERCIZI ARRAY --
        // ESERCIZIO 1
        Console.WriteLine("Quanti numeri vuoi inserire nell'array?");
        int[] arrayUtente = new int[int.Parse(Console.ReadLine()!)];
        int sommaUtente = 0;

        for (int i = 0; i < arrayUtente.Length; i++)
        {
            Console.Write($"Inserisci numero alla posizione {i+1}:");
            arrayUtente[i] = int.Parse(Console.ReadLine()!);
            sommaUtente += arrayUtente[i];
        }
        Console.WriteLine($"Somma elementi array: {sommaUtente}");
    }
}
