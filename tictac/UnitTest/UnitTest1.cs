using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void TestMethod4()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 3; i++)
                res.Add(1);
            Assert.AreEqual(1, g.checkresult(res));
        }
    }
}
