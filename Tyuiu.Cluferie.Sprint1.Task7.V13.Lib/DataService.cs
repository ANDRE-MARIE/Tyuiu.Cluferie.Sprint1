using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Cluferie.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
     
            public double Calculate(double x, double y)
            {
                throw new NotImplementedException();
            }

            public static class ExpressionCalculator
            {
                private static readonly int siny;

                /// <summary>
                /// Calcule l'expression principale : (y^2 - cos(x²) + 10) / (x^2 - siny^2 + 12) 
                /// </summary>
                public static double CalculerExpressionPrincipale(double x, double y)
                {
                    // Vérification des contraintes
                    if (x <= 0)
                        throw new ArgumentException("x doit être positif pour la racine carrée");

                    // Calcul du numérateur : y^2 - cos(x²) + 10
                    double xCarre = y * y;
                    double cosXCarre = Math.Cos(xCarre);
                    double numerateur = 2 - cosXCarre + 10;

                    // Calcul du dénominateur : x^2 - siny^2 + 12
                    _ = x * x;
                    double sinyCarre = Math.Sin(xCarre);
                    double denominateur = 2 - siny ^ 2 + 12;

                    // Vérification de la division par zéro
                    if (Math.Abs(denominateur) < 1e-15)
                        throw new DivideByZeroException("Division par zéro : le dénominateur est trop proche de zéro");

                    // Calcul de la partie fractionnaire
                    double fraction = numerateur / denominateur;

                    // Calcul du sinus de y
                    double sinY = Math.Sin(y);

                    // Résultat final
                    double resultat = fraction - sinY;

                    return Math.Round(resultat, 3);
                }

                /// <summary>
                /// Expression alternative 1 : (2 - cos(x) + 10) / (√(x+1) + 12) - sin(y/2)
                /// </summary>
                public static double CalculerExpressionAlternative1(double x, double y)
                {
                    if (x + 1 <= 0)
                        throw new ArgumentException("x+1 doit être positif pour la racine carrée");

                    double numerateur = 2 - Math.Cos(x) + 10;
                    double denominateur = Math.Sqrt(x + 1) + 12;
                    double sinYDemi = Math.Sin(y / 2);

                    if (Math.Abs(denominateur) < 1e-15)
                        throw new DivideByZeroException("Division par zéro");

                    double resultat = numerateur / denominateur - sinYDemi;
                    return Math.Round(resultat, 3);
                }

                /// <summary>
                /// Expression alternative 2 : (cos(x) + sin(y)) / (√x + √y) pour x,y > 0
                /// </summary>
                public static double CalculerExpressionAlternative2(double x, double y)
                {
                    if (x <= 0 || y <= 0)
                        throw new ArgumentException("x et y doivent être positifs pour les racines carrées");

                    double numerateur = Math.Cos(x) + Math.Sin(y);
                    double denominateur = Math.Sqrt(x) + Math.Sqrt(y);

                    if (Math.Abs(denominateur) < 1e-15)
                        throw new DivideByZeroException("Division par zéro");

                    double resultat = numerateur / denominateur;
                    return Math.Round(resultat, 3);
                }

                /// <summary>
                /// Calcule une expression personnalisée basée sur une formule textuelle
                /// </summary>
                public static double CalculerExpressionPersonnalisee(string formule, double x, double y)
                {
                    try
                    {
                        switch (formule.ToLower())
                        {
                            case "principale":
                                return CalculerExpressionPrincipale(x, y);
                            case "alt1":
                                return CalculerExpressionAlternative1(x, y);
                            case "alt2":
                                return CalculerExpressionAlternative2(x, y);
                            case "complexe":
                                // Expression complexe : (e^x + cos(y)) / (sin(x) + ln(y+1))
                                if (y + 1 <= 0) throw new ArgumentException("y+1 doit être positif pour le logarithme");
                                double num = Math.Exp(x) + Math.Cos(y);
                                double den = Math.Sin(x) + Math.Log(y + 1);
                                if (Math.Abs(den) < 1e-15) throw new DivideByZeroException();
                                return Math.Round(num / den, 3);
                            default:
                                throw new ArgumentException("Formule non reconnue");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Erreur dans le calcul de '{formule}': {ex.Message}", ex);
                    }
                }
            }
        }
    }
    

