using System;

class Program
{
    static void Main()
    {
        // WHILE
        bool continua = true;

        while(continua)
        {
            Console.WriteLine("Ciclo in esecuzione");
            continua = bool.Parse(Console.ReadLine()!);
        }

        int continua2 = 0;
        while(continua2<10)
        {
            Console.WriteLine("Ciclo in esecuzione");
            continua2 +=1;
            Console.WriteLine(continua2);
        }

        // ESERCIZIO 1
        int n = 0;
        int somma = 0;
        while(n>=0)
        {
            somma += n;
            Console.WriteLine("Inserisci un numero intero positivo (o trova il modo di fuggire ihih):");
            n = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine($"Somma: {somma}");

        // ESERCIZIO 2
        const int segreto = 4;

        int input = 0;
        while(input != segreto)
        {
            Console.WriteLine("Indovina il numero segreto:");
            input = int.Parse(Console.ReadLine()!);
            if(input > segreto)
                Console.WriteLine("Troppo alto!");
            else if(input < segreto)
                Console.WriteLine("Troppo basso!");
            else
                Console.WriteLine("Indovinato!");
        }
        // DO-WHILE

        // ESERCIZIO 1

        const int password = 123456789;
        int input2;
        int counter = 0;
        do
        {
            counter++;
            Console.WriteLine("Inserisci password:");
            input2 = int.Parse(Console.ReadLine()!);
            if(input2 != password)
            {
                Console.WriteLine("Password errata!");
                if(counter == 3)
                    Console.WriteLine("Nessun tentativo rimasto!");
            }
            else
                Console.WriteLine("Password corretta!");
        } while(input2 != password && counter < 3);

        // ESERCIZIO 2
        int input3;
        int somma2 = 0;
        int counter2 = 0;
        do
        {
            Console.WriteLine("Inserisci un numero intero:");
            input3 = int.Parse(Console.ReadLine()!);
            somma2 += input3;
            if(input3 != 0)
                counter2++;
        } while(input3 != 0);

        Console.WriteLine($"Somma: {somma2}, Numeri inseriti: {counter2}");

        // ESERCIZIO 3
        string operazione;
        string risposta;

        Console.WriteLine("Dammi un numero:");
        int inputN = int.Parse(Console.ReadLine()!);
        do
        {
            Console.WriteLine("Che operazione vuoi svolgere? (+ | - | * | /)");
            operazione = Console.ReadLine()!;
            Console.WriteLine("Dammi un altro numero:");
            switch(operazione)
            {
                case "+":
                    inputN += int.Parse(Console.ReadLine()!);
                    break;
                case "-":
                    inputN -= int.Parse(Console.ReadLine()!);
                    break;
                case "*":
                    inputN *= int.Parse(Console.ReadLine()!);
                    break;
                case "/":
                    inputN /= int.Parse(Console.ReadLine()!);
                    break;
                default:
                    Console.WriteLine("Comando non valido.");
                    break;
            }
            Console.WriteLine($"Risultato: {inputN}");
            Console.WriteLine("Vuoi concatenare un'altra operazione? (y/n)");
            risposta = Console.ReadLine()!;
        } while(risposta == "y");


        // FOR
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        // ESERCIZIO 1
        Console.WriteLine("Dammi un numero intero:");
        int nInt = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{nInt}*{i} = {nInt*i}");
        }

        // ESERCIZIO 2
        Console.WriteLine("Quanti numeri interi vuoi inserire?");
        int numeri = int.Parse(Console.ReadLine()!);
        int somma3 = 0;

        for (int i = 0; i < numeri; i++)
        {
            Console.WriteLine($"Dammi il numero {i+1}:");
            somma3 += int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine($"Media: {somma3/numeri}");

        // ESERCIZIO 3
        Console.WriteLine("Dammi un numero intero positivo:");
        int pos = int.Parse(Console.ReadLine()!);
        if(pos > 0)
        {
            for (int i = pos-1; i > 0; i--)
            {
                pos *= i;
            }
            Console.WriteLine($"Risultato del fattoriale: {pos}");
        }
        else
            Console.WriteLine("Numero non valido");
    }
}
