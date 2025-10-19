using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Cluferie.Sprint1.Task3.V18.Lib;

namespace Tyuiu.Cluferie.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double X = 4;
            double Y = 8;
            double Z = 12;
            double wait = 384;
            var res = ds.HowManySquares(X, Y, Z);
            Assert.AreEqual(wait, res);
        }
    }
}
        