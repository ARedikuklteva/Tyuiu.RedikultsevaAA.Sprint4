using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint4.Task2.V29.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3 };

            int res = ds.Calculate(numsArray);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
