

using Tyuiu.Cluferie.Sprint1.Task3.V18.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        
        {
            // Demande à l'utilisateur d'entrer les dimensions du rectangle et du carré
            Console.Write("Veuillez entrer la largeur du rectangle (A) : ");
            double largeur = Convert.ToDouble(Console.ReadLine());

            Console.Write("Veuillez entrer la hauteur du rectangle (B) : ");
            double hauteur = Convert.ToDouble(Console.ReadLine());

            Console.Write("Veuillez entrer la longueur du côté du carré (C) : ");
            double cote = Convert.ToDouble(Console.ReadLine());

            // Utiliser la Bibliotheque pour calculer le nombre de carrés
            int nombreCarrés = DataService.CalculerNombreCarrés(largeur, hauteur, cote);

            // Afficher le résultat
            Console.WriteLine($"Le nombre de carrés de côté {cote} qui peuvent tenir dans le rectangle de dimensions {largeur} x {hauteur} est : {nombreCarrés}");
        }
    }
}
    
