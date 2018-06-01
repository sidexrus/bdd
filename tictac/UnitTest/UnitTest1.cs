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
        [TestMethod]
        public void TestMethod5()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 10; i++)
                res.Add(0);
            for (int i = 0; i < 10; i += 3)
                res[i] = 1;
            Assert.AreEqual(1, g.checkresult(res));
        }
        public void TestMethod6()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 10; i++)
                res.Add(0);
            for (int i = 1; i < 10; i += 3)
                res[i] = 1;
            Assert.AreEqual(1, g.checkresult(res));
        }
        [TestMethod]
        public void TestMethod7()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 10; i++)
                res.Add(0);
            for (int i = 2; i < 10; i += 3)
                res[i] = 1;
            Assert.AreEqual(1, g.checkresult(res));
        }
        [TestMethod]
        public void TestMethod8()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 10; i++)
                res.Add(0);
            for (int i = 3; i < 6; i++)
                res[i] = 1;
            Assert.AreEqual(1, g.checkresult(res));
        }
        [TestMethod]
        public void TestMethod9()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 10; i++)
                res.Add(0);
            for (int i = 6; i < 9; i++)
                res[i] = 1;
            Assert.AreEqual(1, g.checkresult(res));
        }
        [TestMethod]
        public void TestMethod10()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 10; i++)
                res.Add(0);
            for (int i = 0; i < 9; i += 4)
                res[i] = 1;
            Assert.AreEqual(1, g.checkresult(res));
        }
        public void TestMethod11()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 10; i++)
                res.Add(0);
            for (int i = 2; i < 7; i += 2)
                res[i] = 1;
            Assert.AreEqual(1, g.checkresult(res));
        }
}
