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
    }
}