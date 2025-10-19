using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Cluferie.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
       
         
              // Méthode pour calculer le nombre de carrés dans le rectangle
        public static int CalculerNombreCarrés(double largeur, double hauteur, double cote)
        {
            if (cote <= 0 || largeur <= 0 || hauteur <= 0)
            {
                throw new ArgumentException("Les dimensions doivent être supérieures à zéro.");
            }

            int carrésEnLargeur = (int)(largeur / cote); // Nombre de carrés qui tiennent en largeur
            int carrésEnHauteur = (int)(hauteur / cote); // Nombre de carrés qui tiennent en hauteur

            return carrésEnLargeur * carrésEnHauteur; // Total des carrés
        }

        public double HowManySquares(double a, double b, double c)
        {
            throw new NotImplementedException();
        }
    }
}
        
