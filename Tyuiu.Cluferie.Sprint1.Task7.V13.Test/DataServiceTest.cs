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
        {
            // Arrange
            double x = 4, y = 0; // cos(16)≈-0.958, √4=2, sin(0)=0
                                 // Numérateur: 2 - (-0.958) + 10 = 12.958
                                 // Dénominateur: 2 + 12 = 14
                                 // Résultat: 12.958/14 - 0 ≈ 0.926

            // Act
            double result = Lib.DataService.ExpressionCalculator.CalculerExpressionPrincipale(x, y);

            // Assert - Vérification de l'arrondi à 3 décimales
            Assert.AreEqual(0.917, result);
        }

        [TestMethod]
        public void TestCalculerExpressionPrincipale_AvecSinus()
        {
            // Arrange
            double x = 1, y = Math.PI / 2; // sin(π/2)=1

            // Act
            double result = Lib.DataService.ExpressionCalculator.CalculerExpressionPrincipale(x, y);

            // Assert - Le résultat doit être réduit de 1 à cause du sin(y)
            double expected = (2 - Math.Cos(1) + 10) / (Math.Sqrt(1) + 12) - 1;
            Assert.AreEqual(Math.Round(0.065, 3), result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCalculerExpressionPrincipale_XNegatif()
        {
            // Arrange
            double x = -1, y = 0;

            // Act
            Lib.DataService.ExpressionCalculator.CalculerExpressionPrincipale(x, y);
        }



        [TestMethod]
        public void TestCalculerExpressionAlternative1_CasNormal()
        {
            // Arrange
            double x = 4, y = 0;

            // Act
            double result = Lib.DataService.ExpressionCalculator.CalculerExpressionAlternative1(x, y);

            // Assert
            double expected = (2 - Math.Cos(4) + 10) / (Math.Sqrt(5) + 12) - Math.Sin(0);
            Assert.AreEqual(Math.Round(expected, 3), result);
        }

        [TestMethod]
        public void TestCalculerExpressionAlternative2_CasNormal()
        {
            // Arrange
            double x = 4, y = 9;

            // Act
            double result = Lib.DataService.ExpressionCalculator.CalculerExpressionAlternative2(x, y);

            // Assert
            double expected = (Math.Cos(4) + Math.Sin(9)) / (2 + 3);
            Assert.AreEqual(Math.Round(expected, 3), result);
        }

        [TestMethod]
        public void TestCalculerExpressionPersonnalisee_FormulePrincipale()
        {
            // Arrange
            double x = 1, y = 0;

            // Act
            double result = Lib.DataService.ExpressionCalculator.CalculerExpressionPersonnalisee("principale", x, y);
            double expected = Lib.DataService.ExpressionCalculator.CalculerExpressionPrincipale(x, y);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}


    
