
using Tyuiu.Cluferie.Sprint1.Task5.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
        Console.WriteLine("*******************************************************************************************");

        Console.WriteLine("Введите значение Х:");
        double x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*******************************************************************************************");

        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                               *");
        Console.WriteLine("*******************************************************************************************");

        Console.WriteLine("=== PROGRAMME EXTRACTION CHIFFRE FRACTIONNAIRE ===");

        // Lecture du nombre réel positif
        Console.Write("Entrez un nombre réel positif x : ");


        // Vérification que le nombre est positif
        if (x < 0)
        {
            Console.WriteLine("Erreur : Le nombre doit être positif !");
            return;
        }


        // Utilisation de la bibliothèque pour obtenir le résultat
        int premierChiffre = Convert.ToInt32(x);

        // Affichage du résultat
        Console.WriteLine($"Pour x = {x}, le premier chiffre de la partie fractionnaire est : {premierChiffre}");

        Console.WriteLine("\nAppuyez sur une touche pour quitter...");
        Console.ReadKey();
    }

}
