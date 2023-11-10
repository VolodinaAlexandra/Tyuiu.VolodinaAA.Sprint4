﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint4.Task7.V2.Lib;

namespace Tyuiu.VolodinaAA.Sprint4.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string value = "597643158942";
            int res = ds.Calculate(n, m, value);
            int wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}
