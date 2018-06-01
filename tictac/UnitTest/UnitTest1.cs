using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tictac;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            game g = new game();
            g.next_step();
            Assert.AreEqual(false, g.x_o);
        }
    }
}
