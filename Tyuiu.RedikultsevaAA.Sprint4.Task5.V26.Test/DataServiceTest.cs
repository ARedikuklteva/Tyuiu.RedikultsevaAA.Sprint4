using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint4.Task5.V26.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -4, -3, -2, -1, 0, },
                                          { 1, 2, 3, 4, 3, },
                                          { -2, -1, 0, 1, 2, },
                                          { -3, -4, -3, -2, -1, },
                                          { 4, 3, 2, 1, 0, } };

            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { -4, -3, -2, -1, 0, },
                                          { 1, 1, 1, 1, 1, },
                                          { -2, -1, 0, 1, 1, },
                                          { -3, -4, -3, -2, -1, },
                                          { 1, 1, 1, 1, 0, } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
