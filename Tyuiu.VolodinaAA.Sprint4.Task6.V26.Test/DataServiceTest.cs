using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint4.Task6.V26.Lib;

namespace Tyuiu.VolodinaAA.Sprint4.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            string[] array = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
            string[] res = ds.Calculate(array);
            string[] wait = new string[] { "Тюмень", "Тамбов" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
