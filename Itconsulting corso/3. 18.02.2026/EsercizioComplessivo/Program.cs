using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Registrazione--");
        Console.Write("Nome utente: ");
        string usernameR = Console.ReadLine()!;
        Console.Write("Password: ");
        string passwordR = Console.ReadLine()!;

        do
        {
            Console.WriteLine("\n--Login--");
            Console.Write("Nome utente: ");
            string usernameL = Console.ReadLine()!;
            Console.Write("Password: ");
            string passwordL = Console.ReadLine()!;

            if(usernameL == usernameR && passwordL == passwordR)
            {
                bool logged = true;

                Console.WriteLine("\nLogin effettuato!");

                while(logged)
                {
                    Console.WriteLine("\nCosa vorresti fare ora?\n\t- Fai partire il countdown -c\n\t- Effettua il logout -o");
                    switch(Console.ReadLine())
                    {
                        case "c":
                            Console.WriteLine("\nQuanto deve durare? Dammi un numero intero");
                            for (int i = int.Parse(Console.ReadLine()!); i > 0; i--)
                                Console.WriteLine($"Conto alla rovescia: {i}");
                            Console.WriteLine("BOOM!");
                            break;
                        case "o":
                            logged = false;
                            Console.WriteLine("Logout effettuato.");
                            break;
                        default:
                            Console.WriteLine("Comando non valido.");
                            break;
                    }
                }
            }
            else
                Console.WriteLine("\nNome utente o password errati!");

            Console.WriteLine("\nVuoi rifare il login? (y/n)");
        } while(Console.ReadLine() == "y");

        Console.WriteLine("\nProgramma terminato.");
    }
}