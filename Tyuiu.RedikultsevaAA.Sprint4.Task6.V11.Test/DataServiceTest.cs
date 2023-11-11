using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint4.Task6.V11.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            var mas = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            var res = ds.Calculate(mas);
            var wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
