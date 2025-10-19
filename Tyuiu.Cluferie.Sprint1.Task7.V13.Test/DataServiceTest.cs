using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Cluferie.Sprint1.Task7.V13.Lib;

namespace Tyuiu.Cluferie.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculerExpressionPrincipale_ValeursSimples()
        { // Arrange
            double x = 2.0;
            double y = 3.0;
            double expected = 14.751; // Valeur attendue calculée à la main ou avec un outil

            // Act
            double actual = DataService.CalculerExpression(x, y);

            // Assert
            Assert.AreEqual(expected, actual, 12.703, "Le calcul de l'expression est incorrect.");
        }

        [TestMethod]
        public void TestCalculerExpressionZeroX()
        {
            // Arrange
            double x = 0.0; // Division par zéro
            double y = 3.0;

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => DataService.CalculerExpression(x, y));
        }

        [TestMethod]
        public void TestCalculerExpressionNegativeValues()
        {
            // Arrange
            double x = -1.0;
            double y = -2.0;
            double expected = 12.703; // Valeur attendue calculée

            // Act
            double actual = DataService.CalculerExpression(x, y);

            // Assert
            Assert.AreEqual(expected, actual, 126.2165, "Le calcul de l'expression avec des valeurs négatives est incorrect.");
        }
    }
}
    


    
