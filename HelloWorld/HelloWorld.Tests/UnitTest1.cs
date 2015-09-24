using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Calculator;

namespace HelloWorld.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Withdraw_ValidAmount_ChangesBalance()
        {
            // arrange
            double currentBalance = 10.0;
            double withdrawal = 1.0;
            double expected = 9.0;
            var account = new Calc("JohnDoe", currentBalance);
            // act
            account.Withdraw(withdrawal);
            double actual = account.Balance;
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Withdraw_AmountMoreThanBalance_Throws()
        {
            // arrange
            var account = new Calc("John Doe", 10.0);
            // act
            account.Withdraw(11.0);
            // assert is handled by the ExpectedException
        }

    }
}
