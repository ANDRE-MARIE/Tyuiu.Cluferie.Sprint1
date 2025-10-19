using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Cluferie.Sprint1.Task6.V7.Lib;

namespace Tyuiu.Cluferie.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSupprimerDerniereLettre()
        {
            // Arrange
            string input = "Bonjour le monde";
            string expected = "Bonjou l mond"; // Suppression de la dernière lettre de chaque mot

            // Act
            string actual = DataService.SupprimerDerniereLettre(input);

            // Assert
            Assert.AreEqual(expected, actual, "La suppression de la dernière lettre est incorrecte.");
        }

        [TestMethod]
        public void TestSupprimerDerniereLettreEmpty()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string actual = DataService.SupprimerDerniereLettre(input);

            // Assert
            Assert.AreEqual(expected, actual, "Pour une entrée vide, le résultat doit également être vide.");
        }

        [TestMethod]
        public void TestSupprimerDerniereLettreWhitespace()
        {
            // Arrange
            string input = "   "; // Entrée constituée uniquement d'espaces
            string expected = "";

            // Act
            string actual = DataService.SupprimerDerniereLettre(input);

            // Assert
            Assert.AreEqual(expected, actual, "Pour une entrée constituée d'espaces, le résultat doit être vide.");
        }
    }
}

    
