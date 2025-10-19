using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Cluferie.Sprint1.Task3.V18.Lib;

namespace Tyuiu.Cluferie.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public class BibliothequeTests
        {
            [TestMethod]
            public void TestCalculerNombreCarrés()
            {
                // Arrange
                double largeur = 10.0;
                double hauteur = 10.0;
                double cote = 2.0;
                int expected = 25; // 2x2 carrés dans un 10x10

                // Act
                int actual = Lib.DataService.CalculerNombreCarrés(largeur, hauteur, cote);

                // Assert
                Assert.AreEqual(expected, actual, "Le calcul du nombre de carrés est incorrect.");
            }

            [TestMethod]
            public void TestCalculerNombreCarrésZero()
            {
                // Arrange
                double largeur = 10.0;
                double hauteur = 10.0;
                double cote = 0.0; // Carré de côté 0

                // Act & Assert
                Assert.ThrowsException<ArgumentException>(() => Lib.DataService.CalculerNombreCarrés(largeur, hauteur, cote));
            }

            [TestMethod]
            public void TestCalculerNombreCarrésNegative()
            {
                // Arrange
                double largeur = 10.0;
                double hauteur = 10.0;
                double cote = -2.0; // Carré de côté négatif

                // Act & Assert
                Assert.ThrowsException<ArgumentException>(() => Lib.DataService.CalculerNombreCarrés(largeur, hauteur, cote));
            }
        }
    }
}