using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuildAndTest.Models;

namespace BuildAndTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            BusinessModel bs = new BusinessModel();
            Assert.AreEqual(3, bs.GetTheIdValue());
        }

        [TestMethod]
        public void TestMethod2()
        {

            BusinessModel bs = new BusinessModel();
            Assert.AreEqual(2, bs.GetTheIdValue());
        }
    }
}
