using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Cluferie.Sprint1.Task2.V19.Lib
{
    public class DataService : ISprint1Task2V19
    {
        private double pouces;

        public static double ConvertirPoucesEnMetres(int pouces)
        {
            throw new NotImplementedException();
        }

        public double ConvertInchToKm(int value)
        {
            const double conversionFactor = 0.0254; // 1 pouce = 0.0254 mètres
            return pouces * conversionFactor;
        }
    }
}
