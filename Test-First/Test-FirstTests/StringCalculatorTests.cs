using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_First_dki_cma.Tests
{
    [TestClass()]
    public class StringCalculatorTests
    {
        [TestMethod()]
        public void NulNumbers()
        {
           var Calculator = new StringCalculator();
           Assert.AreEqual(0, Calculator.Add(""));
        }
        [TestMethod()]
        public void OneNumbers()
        {
            var Calculator = new StringCalculator();
            Assert.AreEqual(4, Calculator.Add("4"));
        }

        [TestMethod()]
        public void TwoNumbers()
        {
            var Calculator = new StringCalculator();
            Assert.AreEqual(9, Calculator.Add("4,5"));
        }

        [TestMethod()]
        public void ThreeNumbers()
        {
            var Calculator = new StringCalculator();
            Assert.AreEqual(9, Calculator.Add("4,2,3"));
        }

        [TestMethod()]
        public void TenNumbers()
        {
            var Calculator = new StringCalculator();
            Assert.AreEqual(45, Calculator.Add("4,2,3,3,4,5,6,2,6,10"));
        }

        [TestMethod()]
        public void ZeilenumbruchNumbers()
        {
            var Calculator = new StringCalculator();
            Assert.AreEqual(6, Calculator.Add("1\n2,3"));
            
        }

        [TestMethod()]
        public void ZeilenumbruchNumbers2()
        {
            var Calculator = new StringCalculator();
            Assert.AreEqual(6, Calculator.Add("1,2;3"));
        }

        [TestMethod()]
        public void NegativesNumbers()
        {
            var Calculator = new StringCalculator();
            Assert.AreEqual(0, Calculator.Add("-1,-2;-3"));
        }

        [TestMethod()]
        public void ThousendNumbers()
        {
            var Calculator = new StringCalculator();
            Assert.AreEqual(2, Calculator.Add("2,1001"));
        }

        [TestMethod()]

        public void CalledCount() 
        {
            var Calculator = new StringCalculator();
            Calculator.Add("2,1001");
            Assert.AreEqual(1, Calculator.CalledCount);
        }

    }
}