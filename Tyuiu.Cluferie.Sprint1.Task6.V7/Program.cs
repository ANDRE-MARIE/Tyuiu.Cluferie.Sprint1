
using Tyuiu.Cluferie.Sprint1.Task6.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
       
            // Demande à l'utilisateur de saisir du texte
            Console.WriteLine("Veuillez saisir du texte : ");
        string? v = Console.ReadLine();
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
        string input = v;
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.

        // Utiliser la Bibliotheque pour traiter le texte
        string resultat = DataService.SupprimerDerniereLettre(input);

            // Afficher le résultat
            Console.WriteLine("Résultat : " + resultat);
        }
    }

        
    
