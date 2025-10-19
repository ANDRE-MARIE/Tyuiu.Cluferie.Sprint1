using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Cluferie.Sprint1.Task1.V8.Lib;

namespace Tyuiu.Cluferie.Sprint1.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double X = 1.0;
            double A = 2.0;
            var res = ds.Calculate(X, A);
            Assert.AreEqual(2, res);
        }
    }
}