using System;

class Program
{
    static void Main()
    {
        Cane mioCane = new Cane();
        mioCane.FaiVerso();
        mioCane.Scodinzola();
        Animale a = mioCane;
        a.FaiVerso();
        mioCane.Cammina();
        Animale b = new Animale();
        b.Cammina();
    }
}