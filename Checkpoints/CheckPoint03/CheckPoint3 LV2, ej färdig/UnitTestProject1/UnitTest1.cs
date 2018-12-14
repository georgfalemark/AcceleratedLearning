using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        List<string> x = new List<string>();

        [TestMethod]
        public void TestMethod1()
        {
            var input = new List<string> { "a", "b", "c", "d", "e" };
            List<string> result = Program.ReOrderList(input);
            Assert.AreEqual(new List<string> { "a", "b", "c", "e", "d" }, result);
        }
    }
}
