using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;


namespace UnitTestAccount
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance());
        }

        public void TestMethodDeposit()
        {
            Account acc = new Account(500000);
            acc.Deposit(100000);
            Assert.AreEqual(400000, acc.Balance());
            acc.Deposit(100000);
            Assert.AreEqual(300000, acc.Balance());
        }

        public void TestMethodWithdraw()
        {
            Account acc = new Account(300000);
            acc.Deposit(100000);
            Assert.AreEqual(400000, acc.Balance());
            acc.Deposit(100000);
            Assert.AreEqual(500000, acc.Balance());
        }

        public void TestMethod()
        {
            Account acc = new Account(300000);
            acc.Deposit(100000);
            Assert.AreEqual(200000, acc.Balance());
            acc.Deposit(100000);
            Assert.AreEqual(300000, acc.Balance());
        }
    }
}
