using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product prod = new Product();
            prod.StartDate = DateTime.Parse("01/12/2015");
            prod.EndDate = DateTime.Parse("07/10/2018");
            bool flag = prod.IsValid();
            Assert.IsTrue(flag);           
        }
    }
}
