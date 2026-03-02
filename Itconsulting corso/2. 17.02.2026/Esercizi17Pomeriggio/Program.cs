using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main()
    {
        // IF-ELSE
        int a = 20, b = 15;

        if(a>b)
        {
            Console.WriteLine($"{a} è maggiore di {b}");
        }
        else
        {
            Console.WriteLine($"{a} è minore di {b}");
        }
        
        // ESERCIZIO 1
        Console.Write("Dammi un numero intero: ");
        int numero = int.Parse(Console.ReadLine()!);

        if(numero % 2 == 0)
            Console.WriteLine($"Il numero {numero} è pari");
        else
            Console.WriteLine($"Il numero {numero} è dispari");

        // ESERCIZIO 2
        const int passwordPredefinita = 1234567890;
        Console.Write("Inserisci password composta da soli numeri: ");
        int passwordNumerica = int.Parse(Console.ReadLine()!);

        if(passwordNumerica == passwordPredefinita)
            Console.WriteLine("Accesso consentito");
        else
            Console.WriteLine("Accesso negato");

         // ESERCIZIO 3
        Console.WriteLine("Dammi due numeri: ");
        double numero1 = double.Parse(Console.ReadLine()!);
        double numero2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Vuoi sommare o sottrarre? (+/-)");
        string input = Console.ReadLine()!;

        if(input == "+")
            Console.WriteLine($"Somma: {numero1+numero2}");
        if(input == "-")
            Console.WriteLine($"Differenza: {numero1-numero2}");
        else
            Console.WriteLine("Operatore non valido!"); 
            
        // IF-ELSE IF
        int eta = 15;
        if(eta >= 30)
            Console.WriteLine("Maggiorenne");
        else if(eta >= 13)
            Console.WriteLine("Adolescente");
        else
            Console.WriteLine("Bambino");

        // ESERCIZIO 1
        Console.Write("Dammi un voto da 1 a 10: ");
        int mark = int.Parse(Console.ReadLine()!);

        if(mark >=1 && mark <=4)
            Console.WriteLine("Insufficiente");
        else if(mark >=5 && mark <=6)
            Console.WriteLine("Sufficiente");
        else if(mark >=7 && mark <=8)
            Console.WriteLine("Buono");
        else if(mark >=9 && mark <=10)
            Console.WriteLine("Ottimo");
        else
            Console.WriteLine("Non valido");

        // ESERCIZIO 2
        Console.WriteLine("Dimmi la tua altezza:");
        float height = float.Parse(Console.ReadLine()!);
        Console.WriteLine("Dimmi il tuo peso:");
        float weight = float.Parse(Console.ReadLine()!);

        float bmi = weight / (height*height);

        if(bmi < 18.5)
            Console.WriteLine("Sottopeso");
        else if(bmi >= 18.5 && bmi < 25)
            Console.WriteLine("Normopeso");
        else if(bmi >= 25 && bmi < 30)
            Console.WriteLine("Sovrappeso");
        else
            Console.WriteLine("Obesità");

        // ESERCIZIO 3
        Console.WriteLine("Dammi una temperatura in Celsius:");
        float tempC = float.Parse(Console.ReadLine()!);

        Console.WriteLine("In che unità di misura vuoi convertire questo valore? (f/k/r)");
        string input2 = Console.ReadLine()!;

        float conversion;
        if(input2 == "f")
        {
            conversion = tempC * 1.8f + 32;
            Console.WriteLine($"Temperatura in Fahreneit: {conversion}°F");
        }
        else if(input2 == "k")
        {
            conversion = tempC + 273.15f;
            Console.WriteLine($"Temperatura in Kelvin: {conversion}°K");
        }
        else if(input2 == "r")
        {
            conversion = tempC + 273.15f * 1.8f;
            Console.WriteLine($"Temperatura in Rankine: {conversion}°R");
        }
        else
            Console.WriteLine("Comando non valido!");


        // SWITCH-CASE

        string giorno = "lunedì";

        switch (giorno)
        {
            case "lunedì":
                Console.WriteLine("Inizio settimana");
                break;
            case "venerdì":
                Console.WriteLine("Quasi weekend");
                break;
            default:
                Console.WriteLine("Altro giorno");
                break;
        }

        // ESERCIZIO 1
        Console.WriteLine("Dammi un numero da 1 a 7:");
        int input3 = int.Parse(Console.ReadLine()!);

        switch(input3)
        {
            case 1:
                Console.WriteLine("Lunedì");
                break;
            case 2:
                Console.WriteLine("Martedì");
                break;
            case 3:
                Console.WriteLine("Mercoledì");
                break;
            case 4:
                Console.WriteLine("Giovedì");
                break;
            case 5:
                Console.WriteLine("Venerdì");
                break;
            case 6:
                Console.WriteLine("Sabato");
                break;
            case 7:
                Console.WriteLine("Domenica");
                break;
            default:
                Console.WriteLine("Invalido");
                break;
        }

        // ESERCIZIO 2
        Console.WriteLine("L'area di quale figura geometrica vuoi calcolare tra quadrato/cerchio/triangolo? (q/c/t)");
        string input4 = Console.ReadLine()!;

        switch(input4)
        {
            case "q":
                Console.Write("Dammi la misura del lato: ");
                double lato = double.Parse(Console.ReadLine()!);
                Console.Write($"L'area del quadrato è: {lato*lato}");
                break;
            case "t":
            Console.WriteLine("Dammi la misura della base e dell'altezza:");
                double baseT = double.Parse(Console.ReadLine()!);
                double altezza = double.Parse(Console.ReadLine()!);
                Console.Write($"L'area del triangolo è: {baseT*altezza/2}");
                break;
            case "c":
            Console.Write("Dammi la misura del raggio: ");
                double raggio = double.Parse(Console.ReadLine()!);
                Console.Write($"L'area del cerchio è: {3.14*raggio*raggio}");
                break;
            default:
                Console.Write("Input non valido");
                break;
        }

        // ESERCIZIO EXTRA

        Console.WriteLine("Dammi un numero:");
        int input5 = int.Parse(Console.ReadLine()!);

        switch(input5 % 2 == 0)
        {
            case true:
                if(input5 >= 5)
                    Console.WriteLine("Numero pari e maggiore o uguale a 5");
                else
                    Console.WriteLine("Numero pari e minore di 5");
                break;            
            default:
                if(input5 >= 5)
                    Console.WriteLine("Numero dispari e maggiore o uguale a 5");
                else
                    Console.WriteLine("Numero dispari e minore di 5");
                break;
        }
    }
}
