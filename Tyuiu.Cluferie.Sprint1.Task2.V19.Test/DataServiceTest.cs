using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Cluferie.Sprint1.Task2.V19.Lib;

    namespace Tyuiu.Cluferie.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {

        public void TestConvertirPoucesEnMetres()
        {
            // Arrange
            int pouces = 39; // Exemple: 39 pouces
            double expected = 0.993; // 39 pouces en mètres (0.993 mètres)

            // Act
            double actual = DataService.ConvertirPoucesEnMetres(pouces);

            // Assert
            Assert.AreEqual(expected, actual, 0.001, "La conversion des pouces en mètres ne correspond pas.");
        }

        }
    }
    


