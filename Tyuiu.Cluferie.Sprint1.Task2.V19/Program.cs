using Tyuiu.Cluferie.Sprint1.Task2.V19.Lib;
internal class Program
{
    private static void Main(string[] args)

    { 
            DataService ds = new DataService();
       
        {
            // Demande à l'utilisateur d'entrer la distance en pouces
            Console.Write("Veuillez entrer la distance en pouces : ");
            int pouces = Convert.ToInt32(Console.ReadLine());

            // Conversion de pouces à mètres
            double distanceEnMetres = ConvertirPoucesEnMetres(pouces);

            // Afficher le résultat avec trois décimales
            Console.WriteLine($"La distance en mètres est : {distanceEnMetres:F3}");
        }

        // Méthode pour convertir les pouces en mètres
        static double ConvertirPoucesEnMetres(int pouces)
        {
            const double conversionFactor = 0.0254; // 1 pouce = 0.0254 mètres
            return pouces * conversionFactor;
        }
    }
}
        
