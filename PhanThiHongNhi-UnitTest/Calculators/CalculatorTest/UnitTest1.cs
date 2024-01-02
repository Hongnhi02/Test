using Calculators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void TestAddOperator()
        {
            int expected, actual;
            Calculation c = new Calculation(10, 5);
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            int expected, actual;
            Calculation c = new Calculation(10, 5);
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            int expected, actual;
            Calculation c = new Calculation(10, 5);
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            int expected, actual;
            Calculation c = new Calculation(10, 5);
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
    }
}
