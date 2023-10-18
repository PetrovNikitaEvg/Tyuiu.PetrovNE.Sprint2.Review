using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint2.TaskReview.V8.Lib;

namespace Tyuiu.PetrovNE.Sprint2.TaskReview.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2, y = 1;
            bool wait = true;
            Assert.AreEqual(ds.CheckDotInShadedArea(x, y), wait);

        }
    }
}
