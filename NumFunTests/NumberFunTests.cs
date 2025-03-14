using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumFun.Tests
{
    [TestClass()]
    public class NumberFunTests
    {
        /// <summary>
        /// UseCase1 values: 5, 10, expected 10
        /// </summary>
        [TestMethod()]
        public void BiggestTestCase1()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 10;

            // Act
            int actual = NumberFun.Biggest(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UseCase2 values: 10, 5, expected 10
        /// </summary>
        [TestMethod()]
        public void BiggestTestCase2()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int expected = 10;

            // Act
            int actual = NumberFun.Biggest(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UseCase3 values: 5, 5, expected 5
        /// </summary>
        [TestMethod()]
        public void BiggestTestCase3()
        {
            // Arrange
            int a = 5;
            int b = 5;
            int expected = 5;

            // Act
            int actual = NumberFun.Biggest(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UseCase5 Test for DivideByZeroException
        /// </summary>
        [TestMethod()]
        public void DivisionTestCase5()
        {
            // Arrange
            double Numerator = 1;
            double Denominator = 0;

            // Act
            try
            {
                var actual = NumberFun.Division(Numerator, Denominator);
            }
            catch (DivideByZeroException)
            {
                return;
            }

            // Assert
            Assert.Fail();
        }
    }
}