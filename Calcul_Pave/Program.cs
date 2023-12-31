namespace Calcul_Pave
{
 // Exercice : Nous avons un couloir de 2 metres de largeur et de n metres de longueur ; et nous avons des 
 // pavés de deux couleurs des noir et des blanc ; on veux calculer toutes les possibilités de pose .
    
    internal class Program
    {

        // Solution  1
        static void Main(string[] args)
        {
            double Pave(double n)
            {
                double P1 = 2;
                double P2 = 8;
                double P3 = 0;
                
                for (int i = 3; i <= n; i++) 
                {
                    P3 = 2 * P2 + 4 * P1;
                    P1 = P2;
                    P1 = P3;
                }
                return P3;

            }
            DateTime start = DateTime.Now;
            Console.WriteLine(Pave(50));
            DateTime end = DateTime.Now;
            Console.WriteLine(end - start);


            // Solution 2

            double P(double n)
            {
                double a;
                double b;
                if (n == 1) { return 2; }
                if (n == 2) { return 8; }

                return 2 * P(n - 1) + 4 * P(n - 2);  // La formule de calcul
            }

            start = DateTime.Now;
            Console.WriteLine(P(50));
            end = DateTime.Now;
            Console.WriteLine(end - start);
        }
    }
}