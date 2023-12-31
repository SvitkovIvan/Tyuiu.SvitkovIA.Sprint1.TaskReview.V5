﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint1.TaskReview.V5.Lib;

namespace Tyuiu.SvitkovIA.Sprint1.TaskReview.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = -0.545;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
