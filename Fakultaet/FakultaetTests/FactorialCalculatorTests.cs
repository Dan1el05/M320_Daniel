using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fakultaet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultaet.Tests
{
    [TestClass()]
    public class FactorialCalculatorTests
    {
        [TestMethod()]
        public void ZeroFactorial()
        {
           var calculator = new FactorialCalculator();
            Assert.AreEqual(1, calculator.Calculate(0));
        }

        [TestMethod()]
        public void OneFactorial()
        {
            var calculator = new FactorialCalculator();
            Assert.AreEqual(1, calculator.Calculate(1));
        }

        [TestMethod()]
        public void TwoFactorial()
        {
            var calculator = new FactorialCalculator();
            Assert.AreEqual(2, calculator.Calculate(2));
        }

        [TestMethod()]
        public void FiveFactorial()
        {
            var calculator = new FactorialCalculator();
            Assert.AreEqual(120, calculator.Calculate(5));
        }

        [TestMethod()]
        public void MinusFactorial()
        {
            var calculator = new FactorialCalculator();
            Assert.AreEqual(0, calculator.Calculate(-5));
        }
    }
}