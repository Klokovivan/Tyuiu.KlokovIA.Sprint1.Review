using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlokovIA.Sprint1.Review.V8.Lib;

namespace Tyuiu.KlokovIA.Sprint1.Review.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 4;
            double wait = 18.752;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
