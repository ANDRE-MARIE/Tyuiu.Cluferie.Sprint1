
using Tyuiu.Cluferie.Sprint1.Task7.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        {
            try
            {
                // Demande à l'utilisateur de saisir les valeurs de x et y
                Console.Write("Veuillez entrer la valeur de x : ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Veuillez entrer la valeur de y : ");
                double y = Convert.ToDouble(Console.ReadLine());

                // Calculer l'expression
                double z = CalculerExpression(x, y);

                // Afficher le résultat arrondi à trois décimales
                Console.WriteLine($"Le résultat de l'expression est : {z:F3}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Veuillez entrer des nombres valides.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erreur : Division par zéro. Assurez-vous que x n'est pas égal à zéro.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur est survenue : {ex.Message}");
            }
        }

        // Méthode pour calculer l'expression
        static double CalculerExpression(double x, double y)
        {
            // Vérifie que x n'est pas égal à zéro pour éviter la division par zéro
            if (x == 0)
            {
                throw new DivideByZeroException();
            }

            double z = Math.Pow(y, 2)          // y^2
                     - Math.Cos(Math.Pow(x, 2)) // - cos(x^2)
                     + (10 / Math.Pow(x, 2)) // + 10/x^2
                     - Math.Sin(Math.Pow(y, 2)) // - sin(y^2)
                     + 12;                   // + 12
            return z;
        }
        Console.ReadKey();

        }
    }






