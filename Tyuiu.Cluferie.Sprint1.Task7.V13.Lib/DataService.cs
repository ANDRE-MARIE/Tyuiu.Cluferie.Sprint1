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
       
        public static double CalculerExpression(double x, double y)
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
            }
        }
    
    

