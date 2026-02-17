using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod()]
        public void IsWithinRange_MinInclusiveBound_ReturnsTrue()
        {
            // Arrange
            Validator validator = new();
            double minBoundary = 10;
            double maxBoundary = 100;
            double valueToCheck = 10;

            // Act
            bool result = validator.IsWithinRange(valueToCheck, minBoundary, maxBoundary);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsWithinRange_MaxInclusiveBound_ReturnsTrue()
        {
            // Arrange
            Validator validator = new();
            double maxboundary = 10;
            double valueToCheck = 10;
            double minBoundary = 1;

            // Act
            bool result = validator.IsWithinRange(valueToCheck, minBoundary, maxboundary);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsWithinRange_ValueWithinRange_ReturnsTrue()
        {
            // Arrange
            Validator validator = new();
            double ValueToCheck = 10;
            double minBoundary = 1;
            double maxBoundary = 100;

            // Act
            bool result = validator.IsWithinRange(ValueToCheck, minBoundary, maxBoundary);

            // Assert
            Assert.IsTrue(result);
        }
    }
}