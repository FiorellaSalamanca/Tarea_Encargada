using System;
using _3PrincipioSolid.Rectangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 3;
            rectangle.Height = 6;

            double expected = 18;
            double actual = rectangle.Area();

            Assert.AreEqual(expected, actual);
        }
    }
}
