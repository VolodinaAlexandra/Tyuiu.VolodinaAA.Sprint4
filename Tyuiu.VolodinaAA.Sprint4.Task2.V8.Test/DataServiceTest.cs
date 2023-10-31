using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint4.Task2.V8.Lib;

namespace Tyuiu.VolodinaAA.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            int[] numsArray = { 5, 2, 6, 3, 3, 5, 3, 4, 4, 5, 5 };
            int res = ds.Calculate(numsArray);
            int wait = 29;
            Assert.AreEqual(wait, res);
        }
    }
}
