using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAccount;

namespace BankAccountTests
{
    [TestClass]
    public class AccountTests
    {

        [TestMethod]
        public void Deposit_IncreasesBalance_ReturnsUpdatedBalance()
        {
            // Arrange
            var acct = new Account { AccountNumber = "1234-ABCDE" };

            // Act
            var result = acct.Deposit(100m);

            // Assert
            Assert.AreEqual(100m, acct.Balance, "Balance should be increased by deposit amount.");
        }

        [TestMethod]
        public void Deposit_Zero_ThrowsArgumentOutOfRangeException()
        {
            var acct = new Account { AccountNumber = "0000-AAAAA" };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acct.Deposit(0m));
        }

        [TestMethod]
        public void Deposit_Negative_ThrowsArgumentOutOfRangeException()
        {
            var acct = new Account { AccountNumber = "0001-BBBBB" };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acct.Deposit(-50m));
        }

        [TestMethod]
        public void Withdraw_DecreasesBalance_ReturnsUpdatedBalance()
        {
            // Arrange
            var acct = new Account { AccountNumber = "2222-CCCCC" };
            acct.Deposit(200m);

            // Act
            var result = acct.Withdraw(75m);

            // Assert
            Assert.AreEqual(125m, acct.Balance, "Balance should be decreased by withdrawal amount.");
            Assert.AreEqual(125m, result, "Withdraw should return the updated balance.");
        }

        [TestMethod]
        public void Withdraw_ZeroOrNegative_ThrowsArgumentOutOfRangeException()
        {
            var acct = new Account { AccountNumber = "3333-DDDDD" };
            acct.Deposit(50m);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acct.Withdraw(0m));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acct.Withdraw(-10m));
        }

        [TestMethod]
        public void Withdraw_MoreThanBalance_ThrowsArgumentOutOfRangeException()
        {
            var acct = new Account { AccountNumber = "4444-EEEEE" };
            acct.Deposit(30m);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acct.Withdraw(31m));
        }

        
    }
}