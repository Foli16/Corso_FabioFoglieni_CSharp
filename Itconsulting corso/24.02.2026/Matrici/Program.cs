using System;

class Program
{
    static void Main()
    {
        int[,] matrice = new int[3,3];
        int nRighe = matrice.GetLength(0);
        int nColonne = matrice.GetLength(1);
        int n = nColonne - 1;
        matrice[0,2] = 10;
        matrice[1,1] = 15;
        matrice[2,0] = 20;

        for(int i = 0; i < nRighe; i++)
        {
            for(int j = 0; j < nColonne; i++)
                if(j == n)
                {
                    Console.WriteLine(matrice[i,j]);
                    n--;
                }
        }
    }
}
