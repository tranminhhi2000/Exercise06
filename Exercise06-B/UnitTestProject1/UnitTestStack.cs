using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestStack
    {
        [TestMethod]
        public void TestPush()
        {
            //push some items and count the number
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Pop());
            Assert.AreEqual("2", S.Pop());

        }

        public void TestPeek()
        {
            //push some items and count the number
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Pop());
            Assert.AreEqual(3, S.Count());

        }
        public void TestCount()
        {
            //push some items and count the number
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual(3, S.Count());

        }

        public void TestClear()
        {
            //push some items and count the number
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual(0, S.Count());

        }
    }
}
