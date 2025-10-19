using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Cluferie.Sprint1.Task4.V24.Lib;

namespace Tyuiu.Cluferie.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {


        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 5;
            double wait = 0.124;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, 0.124);
        }
    }
}
