using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Cluferie.Sprint1.Task6.V7.Lib
{
    public class DataService 
    {
       

             public static string SupprimerDerniereLettre(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty; // Si l'entrée est vide, retourner une chaîne vide
            }

            // Séparer les mots, supprimer la dernière lettre de chacun, puis les joindre
            var mots = input.Split(' ')
                            .Select(mot => mot.Length > 0 ? mot.Substring(0, mot.Length - 1) : mot);

            return string.Join(" ", mots);
        }
    }
}
    

    