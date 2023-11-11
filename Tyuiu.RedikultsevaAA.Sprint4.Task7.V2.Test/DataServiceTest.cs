using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint4.Task7.V2.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int rows = 3;
            int colums = 4;
            int[,] matrix = new int[rows, colums];
            string str = "597643158942";

            int res = ds.Calculate(rows, colums, str);
            int wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}
