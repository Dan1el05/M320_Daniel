using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wasserfass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass.Tests
{
    [TestClass()]
    public class WasserfassTests
    {
        [TestMethod()]
        public void befüllendTest()
        {
            //Arrange
            Wasserfass wasserfass1 = new Wasserfass(0, 100);

            //Act
            int fuellstand = wasserfass1.befüllend(40);
            int fuelstand1 = wasserfass1.befüllend(-40);
            int fuelstand2 = wasserfass1.befüllend(150);


            //Assert
            Assert.AreEqual(40, fuellstand);
            Assert.AreEqual(0, fuelstand1);
            Assert.AreEqual(0, fuelstand2);

        }
        [TestMethod()]
        public void entnehmenTest()
        {
            //Arrange
            Wasserfass wasserfass1 = new Wasserfass(50, 100);

            //Act
            int fuellstand3 = wasserfass1.entnehmen(40);
            int fuelstand4 = wasserfass1.entnehmen(-40);
            int fuelstand5 = wasserfass1.entnehmen(150);

            //Assert
            Assert.AreEqual(10, fuellstand3);
            Assert.AreEqual(0, fuelstand4);
            Assert.AreEqual(0, fuelstand5);

        }
        [TestMethod()]

        public void entleerenTest()
        {
            //Arrange
            Wasserfass wasserfass1 = new Wasserfass(50, 100);

            //Act
            int fuellstand = wasserfass1.entleeren();
            //Assert
            Assert.AreEqual(0, fuellstand);


        }
    }
}